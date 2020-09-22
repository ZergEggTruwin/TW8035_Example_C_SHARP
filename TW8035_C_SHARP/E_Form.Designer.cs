namespace TW8035_C_SHARP
{
    partial class E_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.button12 = new System.Windows.Forms.Button();
            this.labelRawTemp = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelMeasureTemp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 2.5D;
            chartArea1.AxisX.Maximum = 35D;
            chartArea1.AxisX.Minimum = 15D;
            chartArea1.AxisY.Interval = 0.05D;
            chartArea1.AxisY.Maximum = 1.2D;
            chartArea1.AxisY.Minimum = 0.8D;
            chartArea1.AxisY.MinorGrid.Interval = double.NaN;
            chartArea1.AxisY.MinorGrid.IntervalOffset = double.NaN;
            chartArea1.AxisY.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Years;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Series2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Black;
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(282, 154);
            this.chart1.TabIndex = 63;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "15.0 ℃";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown1.Location = new System.Drawing.Point(93, 180);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 65;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 4;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown2.Location = new System.Drawing.Point(93, 209);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 68;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "17,5 ℃";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 72;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 4;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown3.Location = new System.Drawing.Point(93, 238);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown3.TabIndex = 71;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "20.0 ℃";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 75;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 4;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown4.Location = new System.Drawing.Point(93, 267);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown4.TabIndex = 74;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 73;
            this.label4.Text = "22.5 ℃";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 78;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 4;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown5.Location = new System.Drawing.Point(93, 296);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown5.TabIndex = 77;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "25.0 ℃";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(219, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 81;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 4;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown6.Location = new System.Drawing.Point(93, 325);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown6.TabIndex = 80;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "27.5 ℃";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(219, 353);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 84;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 4;
            this.numericUpDown7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown7.Location = new System.Drawing.Point(93, 354);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown7.TabIndex = 83;
            this.numericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 82;
            this.label7.Text = "30.0 ℃";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(219, 382);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 87;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DecimalPlaces = 4;
            this.numericUpDown8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown8.Location = new System.Drawing.Point(93, 383);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown8.TabIndex = 86;
            this.numericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 85;
            this.label8.Text = "32.5 ℃";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(219, 411);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 90;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DecimalPlaces = 4;
            this.numericUpDown9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown9.Location = new System.Drawing.Point(93, 412);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown9.TabIndex = 89;
            this.numericUpDown9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 88;
            this.label9.Text = "35.0 ℃";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(219, 583);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 59);
            this.button10.TabIndex = 91;
            this.button10.Text = "Close";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(32, 583);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 59);
            this.button11.TabIndex = 92;
            this.button11.Text = "Reset";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 12);
            this.label10.TabIndex = 93;
            this.label10.Text = "Environment temperature";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(221, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 12);
            this.label11.TabIndex = 94;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(221, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 12);
            this.label12.TabIndex = 96;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 12);
            this.label13.TabIndex = 95;
            this.label13.Text = "Calculated emissivity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 12);
            this.label14.TabIndex = 97;
            this.label14.Text = "Offset";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.DecimalPlaces = 1;
            this.numericUpDown10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown10.Location = new System.Drawing.Point(93, 548);
            this.numericUpDown10.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown10.TabIndex = 98;
            this.numericUpDown10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(220, 547);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 99;
            this.button12.Text = "Save";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // labelRawTemp
            // 
            this.labelRawTemp.AutoSize = true;
            this.labelRawTemp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRawTemp.Location = new System.Drawing.Point(221, 499);
            this.labelRawTemp.Name = "labelRawTemp";
            this.labelRawTemp.Size = new System.Drawing.Size(51, 12);
            this.labelRawTemp.TabIndex = 101;
            this.labelRawTemp.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 499);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 12);
            this.label16.TabIndex = 100;
            this.label16.Text = "RAW Temp";
            // 
            // labelMeasureTemp
            // 
            this.labelMeasureTemp.AutoSize = true;
            this.labelMeasureTemp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMeasureTemp.Location = new System.Drawing.Point(221, 521);
            this.labelMeasureTemp.Name = "labelMeasureTemp";
            this.labelMeasureTemp.Size = new System.Drawing.Size(51, 12);
            this.labelMeasureTemp.TabIndex = 103;
            this.labelMeasureTemp.Text = "label15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 521);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 12);
            this.label17.TabIndex = 102;
            this.label17.Text = "Measure Temp";
            // 
            // E_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 665);
            this.Controls.Add(this.labelMeasureTemp);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelRawTemp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.numericUpDown10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "E_Form";
            this.Text = "E_Form";
            this.Load += new System.EventHandler(this.E_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label labelRawTemp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelMeasureTemp;
        private System.Windows.Forms.Label label17;
    }
}