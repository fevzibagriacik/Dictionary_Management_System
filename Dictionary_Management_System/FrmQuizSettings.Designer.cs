namespace Dictionary_Management_System
{
    partial class FrmQuizSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuizSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTurkish = new System.Windows.Forms.RadioButton();
            this.rbtnEnglish = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTrackBarValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Number:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(208, 38);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(215, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Response Type:";
            // 
            // rbtnTurkish
            // 
            this.rbtnTurkish.AutoSize = true;
            this.rbtnTurkish.Location = new System.Drawing.Point(6, 9);
            this.rbtnTurkish.Name = "rbtnTurkish";
            this.rbtnTurkish.Size = new System.Drawing.Size(112, 31);
            this.rbtnTurkish.TabIndex = 3;
            this.rbtnTurkish.TabStop = true;
            this.rbtnTurkish.Text = "Turkish";
            this.rbtnTurkish.UseVisualStyleBackColor = true;
            this.rbtnTurkish.CheckedChanged += new System.EventHandler(this.rbtnTurkish_CheckedChanged);
            // 
            // rbtnEnglish
            // 
            this.rbtnEnglish.AutoSize = true;
            this.rbtnEnglish.Location = new System.Drawing.Point(124, 9);
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.Size = new System.Drawing.Size(112, 31);
            this.rbtnEnglish.TabIndex = 4;
            this.rbtnEnglish.TabStop = true;
            this.rbtnEnglish.Text = "English";
            this.rbtnEnglish.UseVisualStyleBackColor = true;
            this.rbtnEnglish.CheckedChanged += new System.EventHandler(this.rbtnEnglish_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mode:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(332, 257);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 107);
            this.btnStart.TabIndex = 10;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(-5, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 77);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTrackBarValue
            // 
            this.lblTrackBarValue.AutoSize = true;
            this.lblTrackBarValue.Location = new System.Drawing.Point(430, 38);
            this.lblTrackBarValue.Name = "lblTrackBarValue";
            this.lblTrackBarValue.Size = new System.Drawing.Size(26, 27);
            this.lblTrackBarValue.TabIndex = 12;
            this.lblTrackBarValue.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTurkish);
            this.groupBox1.Controls.Add(this.rbtnEnglish);
            this.groupBox1.Location = new System.Drawing.Point(208, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAll);
            this.groupBox2.Controls.Add(this.rbtnUnknown);
            this.groupBox2.Location = new System.Drawing.Point(202, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 52);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(12, 21);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(62, 31);
            this.rbtnAll.TabIndex = 3;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(109, 21);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(133, 31);
            this.rbtnUnknown.TabIndex = 4;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "Unknown";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            this.rbtnUnknown.CheckedChanged += new System.EventHandler(this.rbtnUnknown_CheckedChanged);
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(208, 146);
            this.mskTime.Mask = "00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(242, 34);
            this.mskTime.TabIndex = 15;
            this.mskTime.ValidatingType = typeof(int);
            this.mskTime.TextChanged += new System.EventHandler(this.mskTime_TextChanged);
            // 
            // FrmQuizSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(516, 415);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTrackBarValue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmQuizSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Settings";
            this.Load += new System.EventHandler(this.FrmQuizSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnTurkish;
        private System.Windows.Forms.RadioButton rbtnEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTrackBarValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnUnknown;
        private System.Windows.Forms.MaskedTextBox mskTime;
    }
}