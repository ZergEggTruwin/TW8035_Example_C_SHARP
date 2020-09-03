using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        byte gainValue = 0;
        float radioOffset = 0;

        HandleRef hr;

        Color[] colorBaseArr = new Color[256];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 256; i++)
            {
                colorBaseArr[i] = Color.FromArgb(i, i, i);
            }
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

                    float[] fArr = new float[4800];

                    gainValue = (byte)(twImage.RadioOffset >> 8);
                    radioOffset = ((twImage.RadioOffset & 0xFF) - 120.0f) / 10.0f;

                    fArr = GenerateTempData(twImage.ImageData, twImage.T_Data1, twImage.T_Data2, twImage.T_Data3, out min, out max);

                    textRecvCnt.Text = twImage.cnt + "";
                    textFPS.Text = twImage.FPS + "";
                    textMax.Text = max + "";
                    textMin.Text = min + "";

                    int maxIdx = fArr.ToList().IndexOf(max);

                    Bitmap bmp = Generate16bitImage(fArr, min, max, maxIdx);

                    pictureBox1.Image = bmp;

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
                    break;
            }
            base.WndProc(ref m);
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

        private float[] GenerateTempData(ushort[] arr, ushort t1, ushort t2, ushort t3, out float min, out float max)
        {
            float[] rtnVal = new float[4800];

            float gainDT = ((float)gainValue / (float)(t2 - t1));

            for (int i = 0; i < 4800; i++)
            {
                rtnVal[i] = (((gainDT * (arr[i] - t1) + t3)) + radioOffset) / 0.98f;
            }

            min = rtnVal.Min();
            max = rtnVal.Max();

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

                numericUpDown1.Value = (decimal)getEmissivity();

                serialPortConnectWrapper(hr.Handle, Marshal.StringToBSTR(portName));

                Thread t1 = new Thread(new ThreadStart(Run));
                t1.Start();
            }
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
            setEmissivity((float)numericUpDown1.Value);
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
    }
}
