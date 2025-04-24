namespace Dictionary_Management_System
{
    partial class FrmQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(86, 23);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(26, 27);
            this.lblQuestionNo.TabIndex = 4;
            this.lblQuestionNo.Text = "0";
            this.lblQuestionNo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(224, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(26, 27);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "0";
            this.lblTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Location = new System.Drawing.Point(86, 102);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(26, 27);
            this.lblTrue.TabIndex = 6;
            this.lblTrue.Text = "0";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Location = new System.Drawing.Point(84, 183);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(26, 27);
            this.lblFalse.TabIndex = 7;
            this.lblFalse.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Meaning:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(415, 254);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(293, 34);
            this.txtAnswer.TabIndex = 10;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Location = new System.Drawing.Point(280, 318);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 107);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Transparent;
            this.btnPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPass.BackgroundImage")));
            this.btnPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPass.Location = new System.Drawing.Point(575, 318);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(133, 107);
            this.btnPass.TabIndex = 12;
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 46);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(152, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 46);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(12, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 46);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(12, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 46);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 187);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(289, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 187);
            this.panel1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(741, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestionNo);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FrmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}