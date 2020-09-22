using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TW8035_C_SHARP
{
    public partial class Form1 : Form
    {
        public const int SEND_RAW = 0;
        public const int SEND_TEMP = 1;

        private const int colorArrCnt = 256;

        byte gainValue = 0;
        float radioOffset = 0;

        HandleRef hr;

        Color[] colorBaseArr = new Color[256];

        float[] eArr = new float[9];
        E_Form eForm;

        List<EmissivityElement> list = new List<EmissivityElement>();

        float gE = 0;
        float gOffset = 0;

        public Form1()
        {
            InitializeComponent();

            //for (int i = 0; i < 256; i++)
            //{
            //    colorBaseArr[i] = Color.FromArgb(i, i, i);
            //}

            comboBox1.SelectedIndex = 0;

            buildEmissivityList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hr = new HandleRef(this, this.Handle);

            IntPtr ip = new IntPtr();

            ip = getPortListForCSharp(1);

            String str1 = Marshal.PtrToStringUni(ip);

            String[] stk = str1.Split('|');

            int i = 0;

            foreach (var word in stk)
            {
                if (word.Length != 0)
                {
                    comboPort.Items.Add(word);
                    comboPort.SelectedIndex = 0;
                    i++;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_COMM_RX_DATA:
                    TW_8035_ImageData twImage = (TW_8035_ImageData)Marshal.PtrToStructure(m.LParam, typeof(TW_8035_ImageData));

                    float max, min, avg;
                    float before;

                    float[] fArr = new float[4800];

                    gainValue = (byte)(twImage.RadioOffset >> 8);
                    radioOffset = ((twImage.RadioOffset & 0xFF) - 120.0f) / 10.0f;

                    gE = calEmissivity((twImage.TempBoard / 100.0f) - 10.0f);
                    gOffset = Properties.Settings.Default.OFFSET;

                    fArr = GenerateTempData(twImage.ImageData, twImage.T_Data1, twImage.T_Data2, twImage.T_Data3, out min, out max, out before);

                    textRecvCnt.Text = twImage.cnt + "";
                    textFPS.Text = twImage.FPS + "";
                    textMax.Text = max + "";
                    textMin.Text = min + "";

                    int maxIdx = fArr.ToList().IndexOf(max);

                    Bitmap bmp = Generate16bitImage(fArr, min, max, maxIdx);

                    pictureBox1.Image = bmp;

                    if(eForm != null && eForm.Visible == true)
                    {
                        eForm.updateTemp(twImage.TempBoard / 100.0f, before, max);
                    }

                    break;
                case WM_COMM_RECV_INFO:
                    TW_8035_DeviceData twCal = (TW_8035_DeviceData)Marshal.PtrToStructure(m.LParam, typeof(TW_8035_DeviceData));
                    break;
                case WM_COMM_RX_TEMP_DATA:
                    TW_8035_TempData twTemp = (TW_8035_TempData)Marshal.PtrToStructure(m.LParam, typeof(TW_8035_TempData));
                    float maxT, minT, avgT;
                    minT = twTemp.TempData.Min();
                    maxT = twTemp.TempData.Max();
                    avgT = twTemp.TempData.Average();

                    textRecvCnt.Text = twTemp.cnt + "";
                    textFPS.Text = twTemp.FPS + "";
                    textMax.Text = maxT + "";
                    textMin.Text = minT + "";

                    int maxTIdx = twTemp.TempData.ToList().IndexOf(maxT);

                    Bitmap bmpT = Generate16bitImage(twTemp.TempData, minT, maxT, maxTIdx);

                    pictureBox1.Image = bmpT;

                    //if (eForm != null && eForm.Visible == true)
                    //{
                    //    eForm.updateTemp(twTemp.TempBoard / 100.0f);
                    //}
                    break;
            }
            base.WndProc(ref m);
        }

        public void Add(float emissivity, float shutterTemp)
        {
            EmissivityElement ee = new EmissivityElement(emissivity, shutterTemp);
            list.Add(ee);
            list.Sort(delegate (EmissivityElement e1, EmissivityElement e2)
            {
                if (e1.shutterTemp > e2.shutterTemp) return 1;
                else if (e1.shutterTemp < e2.shutterTemp) return -1;
                return 0;
            });
        }

        public void buildEmissivityList()
        {
            list = new List<EmissivityElement>();

            Add(Properties.Settings.Default.E_150, 15f);
            Add(Properties.Settings.Default.E_175, 17.5f);
            Add(Properties.Settings.Default.E_200, 20f);
            Add(Properties.Settings.Default.E_225, 22.5f);
            Add(Properties.Settings.Default.E_250, 25f);
            Add(Properties.Settings.Default.E_275, 27.5f);
            Add(Properties.Settings.Default.E_300, 30f);
            Add(Properties.Settings.Default.E_325, 32.5f);
            Add(Properties.Settings.Default.E_350, 35f);
        }

        public float calEmissivity(float temp)
        {
            float rtnVal = 0.0f;

            int listCnt = list.Count;

            int idx = 0;

            for (idx = 0; idx < listCnt; idx++)
            {
                if (list[idx].shutterTemp > temp)
                {
                    break;
                }
            }

            if (idx == 0)
            {
                idx = 1;

            }
            else if (idx == listCnt)
            {
                idx = listCnt - 1;
            }
            else
            {

            }

            float temp1 = list[idx].shutterTemp - list[idx - 1].shutterTemp;
            float temp2 = list[idx].emissivity - list[idx - 1].emissivity;
            float temp3 = temp2 / temp1;
            rtnVal = (temp - list[idx - 1].shutterTemp) * temp3 + list[idx - 1].emissivity;

            return rtnVal;
        }

        private Bitmap Generate16bitImage(float[] arr, float min, float max, int targetIdx)
        {
            Bitmap rtnVal = new Bitmap(80, 60, PixelFormat.Format24bppRgb);

            float perCode = max - min;
            perCode = 255 / perCode;

            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    int ii = (j * 80) + i;
                    //int idx = arr[(j * 80) + i] - 2000;
                    int idx = (int)((arr[ii] - min) * perCode);

                    if (idx > 255)
                    {
                        idx = 255;
                    }
                    if (idx < 0)
                    {
                        idx = 0;
                    }

                    Color c = colorBaseArr[idx];

                    rtnVal.SetPixel(i, j, c);

                    if(ii == targetIdx)
                    {
                        rtnVal.SetPixel(i, j, Color.Red);
                    }
                }
            }
            return rtnVal;
        }

        private float[] GenerateTempData(ushort[] arr, ushort t1, ushort t2, ushort t3, out float min, out float max, out float before)
        {
            float[] rtnVal = new float[4800];

            float gainDT = ((float)gainValue / (float)(t2 - t1));

            for (int i = 0; i < 4800; i++)
            {
                rtnVal[i] = (((gainDT * (arr[i] - t1) + t3)) + radioOffset) / gE + gOffset;
            }

            min = rtnVal.Min();
            max = rtnVal.Max();
            before = (max - gOffset) * gE;

            return rtnVal;
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if(isConnected() == true)
            {
                requestStop();
                Thread.Sleep(200);
                try
                {
                    serialPortCloseWrapper(hr.Handle);
                }
                catch (Exception ex)
                {

                }
                comboPort.Enabled = true;
                btnConn.Text = "Connect";
            }
            else
            {
                String portName = comboPort.SelectedItem.ToString();
                btnConn.Text = "Disconnect";

                serialPortConnectWrapper(hr.Handle, Marshal.StringToBSTR(portName));

                Thread t1 = new Thread(new ThreadStart(Run));
                t1.Start();
            }
        }

        public void drawImageBar(int idx)
        {
            Bitmap bmp = new Bitmap(20, colorArrCnt, PixelFormat.Format24bppRgb);

            float nFTempColorR, nFTempColorG, nFTempColorB, nFUnitColor;
            int nTempColorR, nTempColorG, nTempColorB;
            uint LoopI, nLoopICnt, nLoopICntMod;

            #region 이미지바 생성
            switch (idx)
            {
                case 0: // Gray Scale
                    for (LoopI = 0; LoopI < colorArrCnt; LoopI++)
                    {
                        nTempColorR = (int)((float)LoopI / colorArrCnt * 255f);
                        Color cc = Color.FromArgb(nTempColorR, nTempColorR, nTempColorR);

                        colorBaseArr[LoopI] = cc;

                        for (int i = 0; i < 20; i++)
                        {
                            bmp.SetPixel(i, (colorArrCnt - 1) - (int)LoopI, cc);
                        }
                    }
                    break;
                case 1: // Color 1
                    nFUnitColor = 40.0f;
                    nFTempColorR = nFTempColorG = nFTempColorB = 0.0F;
                    nTempColorR = nTempColorG = nTempColorB = 0;
                    for (LoopI = 0; LoopI < colorArrCnt; LoopI++)
                    {
                        nLoopICnt = LoopI / (uint)nFUnitColor;
                        nLoopICntMod = (LoopI % (uint)nFUnitColor);
                        switch (nLoopICnt)
                        {
                            case 0:
                                nFTempColorB += (80.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 1:
                                nFTempColorR += (80.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorB += (80.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 2:
                                nFTempColorR += (80.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                break;
                            case 3:
                                nFTempColorR += (85.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (140.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB -= (160.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                if (nFTempColorB < 0.0f) { nFTempColorB = 0.0f; }
                                nTempColorB = (int)nFTempColorB;
                                break;
                            case 4:
                                nFTempColorG += (30.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 5:
                                nFTempColorG += (30.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 6:
                                nFTempColorG += (15.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (75.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 7:
                                nFTempColorG += (15.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (50.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 8:
                                nFTempColorR += (5.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (10.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (60.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 9:
                                nFTempColorR += (5.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (15.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (70.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            default:
                                break;
                        }

                        Color cc = Color.FromArgb(nTempColorR, nTempColorG, nTempColorB);

                        colorBaseArr[LoopI] = cc;

                        for (int i = 0; i < 20; i++)
                        {
                            bmp.SetPixel(i, (colorArrCnt - 1) - (int)LoopI, cc);
                        }
                    }
                    break;
                case 2: // Color 2
                    nFUnitColor = 40.0f;
                    nFTempColorR = nFTempColorG = nFTempColorB = 0.0F;
                    nTempColorR = nTempColorG = nTempColorB = 0;
                    for (LoopI = 0; LoopI < colorArrCnt; LoopI++)
                    {
                        nLoopICnt = LoopI / (uint)nFUnitColor;
                        nLoopICntMod = (LoopI % (uint)nFUnitColor);
                        switch (nLoopICnt)
                        {
                            case 0:
                                nFTempColorR += (250.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorB += (250.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 1:
                                nFTempColorR -= (250.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorB -= (50.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 2:
                                nFTempColorG += (250.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (50.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 3:
                                nFTempColorG -= (125.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB -= (250.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 4:
                                nFTempColorR += (125.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (65.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 5:
                                nFTempColorR += (125.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (60.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 6:
                                nFTempColorR -= (10.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG -= (50.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 7:
                                nFTempColorR -= (40.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG -= (200.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 8:
                                nFTempColorR += (20.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (150.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (150.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 9:
                                nFTempColorR += (35.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (105.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (105.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            default:
                                break;
                        }

                        Color cc = Color.FromArgb(nTempColorR, nTempColorG, nTempColorB);

                        colorBaseArr[LoopI] = cc;

                        for (int i = 0; i < 20; i++)
                        {
                            bmp.SetPixel(i, (colorArrCnt - 1) - (int)LoopI, cc);
                        }
                    }
                    break;
                case 3: // Rainbow
                    nFUnitColor = colorArrCnt / 7;
                    nFTempColorR = nFTempColorG = nFTempColorB = 0.0F;
                    nTempColorR = nTempColorG = nTempColorB = 0;
                    for (LoopI = 0; LoopI < colorArrCnt; LoopI++)
                    {
                        nLoopICnt = LoopI / (uint)nFUnitColor;
                        nLoopICntMod = (LoopI % (uint)nFUnitColor);
                        switch (nLoopICnt)
                        {
                            case 0:
                                nFTempColorB += (70.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 1:
                                nFTempColorG += (70.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (150.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 2:
                                nFTempColorG += (70.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB -= (80.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 3:
                                nFTempColorR += (210.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (70.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB -= (140.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 4:
                                nFTempColorR += (40.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (40.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                break;
                            case 5:
                                nFTempColorG -= (110.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (40.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 6:
                                nFTempColorG -= (100.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (55.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 7:
                                nFTempColorR += (5.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (215.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (160.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 8:
                                nFTempColorR += (20.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (150.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (150.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            case 9:
                                nFTempColorR += (102.0f / nFUnitColor); nTempColorR = (int)nFTempColorR;
                                nFTempColorG += (0.0f / nFUnitColor); nTempColorG = (int)nFTempColorG;
                                nFTempColorB += (153.0f / nFUnitColor); nTempColorB = (int)nFTempColorB;
                                break;
                            default:
                                break;
                        }
                        //if ((LoopI + 1) == 255)
                        //{
                        //    nTempColorR = 255;
                        //    nTempColorG = 255;
                        //    nTempColorB = 255;
                        //}

                        Color cc = Color.FromArgb(nTempColorR, nTempColorG, nTempColorB);

                        colorBaseArr[LoopI] = cc;

                        for (int i = 0; i < 20; i++)
                        {
                            bmp.SetPixel(i, (colorArrCnt - 1) - (int)LoopI, cc);
                        }
                    }
                    break;
            }
            #endregion

            pictureBox2.Image = bmp;
        }

        private void Run()
        {
            // 멈춤명령
            requestStop();
            Thread.Sleep(300);
            // Mirror, Flip 원점
            requestImageConvert((char)0, (char)0);
            Thread.Sleep(100);
            // 장비 정보 요청
            requestDeviceInfo();
            Thread.Sleep(200); // 여기서 주지 않으면 가끔 못받아오는 경우 생김
            // FPS 20으로
            //changeFPSCmd((char)30);
            Thread.Sleep(100);
            // 스트리밍 모드 시작
            requestRunStreamingMode();
            Thread.Sleep(10);
        } 

        private void btnStreamming_Click(object sender, EventArgs e)
        {
            // 스트리밍 시작
            requestRunStreamingMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 스트리밍 종료
            requestStop();
        }

        private void btn10FPS_Click(object sender, EventArgs e)
        {
            changeFPSCmd((char)10);
        }

        private void btn20FPS_Click(object sender, EventArgs e)
        {
            changeFPSCmd((char)20);
        }

        private void btn30FPS_Click(object sender, EventArgs e)
        {
            changeFPSCmd((char)30);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendMode(SEND_RAW);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendMode(SEND_TEMP);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eForm = new E_Form(this);

            eForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            requestReset();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setShutterOnOff(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setShutterOnOff(false);
        }

        class EmissivityElement
        {
            public float shutterTemp;
            public float emissivity;

            public EmissivityElement(float emissivity, float shutterTemp)
            {
                this.shutterTemp = shutterTemp;
                this.emissivity = emissivity;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawImageBar((sender as ComboBox).SelectedIndex);
        }
    }
}
