namespace Dictionary_Management_System
{
    partial class FrmWordDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWordDetail));
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.rbtnKnown = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(141, 80);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(298, 34);
            this.txtMean.TabIndex = 7;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(141, 32);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(298, 34);
            this.txtWord.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meaning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Word:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(141, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 88);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(325, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 88);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(0, 323);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 77);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(306, 142);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(133, 31);
            this.rbtnUnknown.TabIndex = 15;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "Unknown";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            this.rbtnUnknown.CheckedChanged += new System.EventHandler(this.rbtnUnknown_CheckedChanged);
            // 
            // rbtnKnown
            // 
            this.rbtnKnown.AutoSize = true;
            this.rbtnKnown.Location = new System.Drawing.Point(141, 142);
            this.rbtnKnown.Name = "rbtnKnown";
            this.rbtnKnown.Size = new System.Drawing.Size(106, 31);
            this.rbtnKnown.TabIndex = 14;
            this.rbtnKnown.TabStop = true;
            this.rbtnKnown.Text = "Known";
            this.rbtnKnown.UseVisualStyleBackColor = true;
            this.rbtnKnown.CheckedChanged += new System.EventHandler(this.rbtnKnown_CheckedChanged);
            // 
            // FrmWordDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(462, 398);
            this.Controls.Add(this.rbtnUnknown);
            this.Controls.Add(this.rbtnKnown);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmWordDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Detail";
            this.Load += new System.EventHandler(this.FrmWordDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rbtnUnknown;
        private System.Windows.Forms.RadioButton rbtnKnown;
    }
}