namespace TW8035_C_SHARP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStreamming = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn30FPS = new System.Windows.Forms.Button();
            this.btn20FPS = new System.Windows.Forms.Button();
            this.btn10FPS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textRecvCnt = new System.Windows.Forms.TextBox();
            this.textFPS = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(22, 27);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(86, 20);
            this.comboPort.TabIndex = 0;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(114, 27);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recv CNT : ";
            // 
            // btnStreamming
            // 
            this.btnStreamming.Location = new System.Drawing.Point(195, 27);
            this.btnStreamming.Name = "btnStreamming";
            this.btnStreamming.Size = new System.Drawing.Size(82, 23);
            this.btnStreamming.TabIndex = 3;
            this.btnStreamming.Text = "Streamming";
            this.btnStreamming.UseVisualStyleBackColor = true;
            this.btnStreamming.Click += new System.EventHandler(this.btnStreamming_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn30FPS
            // 
            this.btn30FPS.Location = new System.Drawing.Point(283, 57);
            this.btn30FPS.Name = "btn30FPS";
            this.btn30FPS.Size = new System.Drawing.Size(82, 23);
            this.btn30FPS.TabIndex = 7;
            this.btn30FPS.Text = "30 FPS";
            this.btn30FPS.UseVisualStyleBackColor = true;
            this.btn30FPS.Click += new System.EventHandler(this.btn30FPS_Click);
            // 
            // btn20FPS
            // 
            this.btn20FPS.Location = new System.Drawing.Point(195, 57);
            this.btn20FPS.Name = "btn20FPS";
            this.btn20FPS.Size = new System.Drawing.Size(82, 23);
            this.btn20FPS.TabIndex = 6;
            this.btn20FPS.Text = "20 FPS";
            this.btn20FPS.UseVisualStyleBackColor = true;
            this.btn20FPS.Click += new System.EventHandler(this.btn20FPS_Click);
            // 
            // btn10FPS
            // 
            this.btn10FPS.Location = new System.Drawing.Point(114, 57);
            this.btn10FPS.Name = "btn10FPS";
            this.btn10FPS.Size = new System.Drawing.Size(75, 23);
            this.btn10FPS.TabIndex = 5;
            this.btn10FPS.Text = "10 FPS";
            this.btn10FPS.UseVisualStyleBackColor = true;
            this.btn10FPS.Click += new System.EventHandler(this.btn10FPS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "FPS : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min : ";
            // 
            // textRecvCnt
            // 
            this.textRecvCnt.Location = new System.Drawing.Point(103, 176);
            this.textRecvCnt.Name = "textRecvCnt";
            this.textRecvCnt.ReadOnly = true;
            this.textRecvCnt.Size = new System.Drawing.Size(77, 21);
            this.textRecvCnt.TabIndex = 11;
            // 
            // textFPS
            // 
            this.textFPS.Location = new System.Drawing.Point(103, 210);
            this.textFPS.Name = "textFPS";
            this.textFPS.ReadOnly = true;
            this.textFPS.Size = new System.Drawing.Size(77, 21);
            this.textFPS.TabIndex = 12;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(103, 244);
            this.textMax.Name = "textMax";
            this.textMax.ReadOnly = true;
            this.textMax.Size = new System.Drawing.Size(77, 21);
            this.textMax.TabIndex = 13;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(103, 278);
            this.textMin.Name = "textMin";
            this.textMin.ReadOnly = true;
            this.textMin.Size = new System.Drawing.Size(77, 21);
            this.textMin.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Set Emissivity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Raw Mode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Temp Mode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(283, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "S.OFF";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(195, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "S.ON";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(352, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Color : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gray Scale",
            "Color 1",
            "Color 2",
            "Rainbow"});
            this.comboBox1.Location = new System.Drawing.Point(73, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 20);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 308);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textFPS);
            this.Controls.Add(this.textRecvCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn30FPS);
            this.Controls.Add(this.btn20FPS);
            this.Controls.Add(this.btn10FPS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStreamming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.comboPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStreamming;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn30FPS;
        private System.Windows.Forms.Button btn20FPS;
        private System.Windows.Forms.Button btn10FPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRecvCnt;
        private System.Windows.Forms.TextBox textFPS;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

