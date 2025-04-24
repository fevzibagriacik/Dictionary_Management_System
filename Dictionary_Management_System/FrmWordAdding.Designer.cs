namespace Dictionary_Management_System
{
    partial class FrmWordAdding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWordAdding));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rbtnKnown = new System.Windows.Forms.RadioButton();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meaning:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(159, 50);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(298, 34);
            this.txtWord.TabIndex = 2;
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(159, 98);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(298, 34);
            this.txtMean.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(369, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 65);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(-3, 240);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 77);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rbtnKnown
            // 
            this.rbtnKnown.AutoSize = true;
            this.rbtnKnown.Location = new System.Drawing.Point(159, 152);
            this.rbtnKnown.Name = "rbtnKnown";
            this.rbtnKnown.Size = new System.Drawing.Size(106, 31);
            this.rbtnKnown.TabIndex = 12;
            this.rbtnKnown.TabStop = true;
            this.rbtnKnown.Text = "Known";
            this.rbtnKnown.UseVisualStyleBackColor = true;
            this.rbtnKnown.CheckedChanged += new System.EventHandler(this.rbtnKnown_CheckedChanged);
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(324, 152);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(133, 31);
            this.rbtnUnknown.TabIndex = 13;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "Unknown";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            this.rbtnUnknown.CheckedChanged += new System.EventHandler(this.rbtnUnknown_CheckedChanged);
            // 
            // FrmWordAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.rbtnUnknown);
            this.Controls.Add(this.rbtnKnown);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmWordAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Word";
            this.Load += new System.EventHandler(this.FrmWordAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton rbtnKnown;
        private System.Windows.Forms.RadioButton rbtnUnknown;
    }
}