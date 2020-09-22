using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TW8035_C_SHARP
{
    public partial class E_Form : Form
    {
        Form1 parent;
        float shutterTemp = 0.0f;

        public E_Form(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public void updateTemp(float shutterTemp, float before, float max)
        {
            this.shutterTemp = shutterTemp - 10;

            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(this.shutterTemp, 0);
            chart1.Series[1].Points.AddXY(this.shutterTemp, 10);

            label11.Text = this.shutterTemp.ToString("00.0");
            labelRawTemp.Text = before.ToString("00.0");
            labelMeasureTemp.Text = max.ToString("00.0");

            float e = parent.calEmissivity(this.shutterTemp);

            label12.Text = e.ToString("0.00000");
        }

        float[] eArr = new float[9];

        private void E_Form_Load(object sender, EventArgs e)
        {
            initControls();
        }

        private void initControls()
        {
            eArr[0] = Properties.Settings.Default.E_150;
            eArr[1] = Properties.Settings.Default.E_175;
            eArr[2] = Properties.Settings.Default.E_200;
            eArr[3] = Properties.Settings.Default.E_225;
            eArr[4] = Properties.Settings.Default.E_250;
            eArr[5] = Properties.Settings.Default.E_275;
            eArr[6] = Properties.Settings.Default.E_300;
            eArr[7] = Properties.Settings.Default.E_325;
            eArr[8] = Properties.Settings.Default.E_350;

            for (int i = 0; i < 9; i++)
            {
                NumericUpDown nud = (NumericUpDown)this.Controls.Find("numericUpDown" + (i + 1), false)[0];

                nud.Value = (decimal)eArr[i];
            }

            RebuildChart();

            numericUpDown10.Value = (decimal)Properties.Settings.Default.OFFSET;
        }

        private void RebuildChart()
        {
            chart1.Series[0].Points.Clear();

            chart1.Series[0].Points.AddXY(15, Properties.Settings.Default.E_150);
            chart1.Series[0].Points.AddXY(17.5, Properties.Settings.Default.E_175);
            chart1.Series[0].Points.AddXY(20, Properties.Settings.Default.E_200);
            chart1.Series[0].Points.AddXY(22.5, Properties.Settings.Default.E_225);
            chart1.Series[0].Points.AddXY(25, Properties.Settings.Default.E_250);
            chart1.Series[0].Points.AddXY(27.5, Properties.Settings.Default.E_275);
            chart1.Series[0].Points.AddXY(30, Properties.Settings.Default.E_300);
            chart1.Series[0].Points.AddXY(32.5, Properties.Settings.Default.E_325);
            chart1.Series[0].Points.AddXY(35, Properties.Settings.Default.E_350);

            chart1.Series[2].Points.Clear();
            chart1.Series[2].Points.AddXY(0, 1);
            chart1.Series[2].Points.AddXY(42.5, 1);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Name)
            {
                case "button1":
                    Properties.Settings.Default.E_150 = (float)numericUpDown1.Value;
                    break;
                case "button2":
                    Properties.Settings.Default.E_175 = (float)numericUpDown2.Value;
                    break;
                case "button3":
                    Properties.Settings.Default.E_200 = (float)numericUpDown3.Value;
                    break;
                case "button4":
                    Properties.Settings.Default.E_225 = (float)numericUpDown4.Value;
                    break;
                case "button5":
                    Properties.Settings.Default.E_250 = (float)numericUpDown5.Value;
                    break;
                case "button6":
                    Properties.Settings.Default.E_275 = (float)numericUpDown6.Value;
                    break;
                case "button7":
                    Properties.Settings.Default.E_300 = (float)numericUpDown7.Value;
                    break;
                case "button8":
                    Properties.Settings.Default.E_325 = (float)numericUpDown8.Value;
                    break;
                case "button9":
                    Properties.Settings.Default.E_350 = (float)numericUpDown9.Value;
                    break;
            }

            Properties.Settings.Default.Save();

            RebuildChart();

            parent.buildEmissivityList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OFFSET = (float)numericUpDown10.Value;

            Properties.Settings.Default.Save();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OFFSET = 0;
            Properties.Settings.Default.E_150 = 1;
            Properties.Settings.Default.E_175 = 1;
            Properties.Settings.Default.E_200 = 1;
            Properties.Settings.Default.E_225 = 1;
            Properties.Settings.Default.E_250 = 1;
            Properties.Settings.Default.E_275 = 1;
            Properties.Settings.Default.E_300 = 1;
            Properties.Settings.Default.E_325 = 1;
            Properties.Settings.Default.E_350 = 1;

            Properties.Settings.Default.Save();

            initControls();

            RebuildChart();
            parent.buildEmissivityList();
        }
    }
}
