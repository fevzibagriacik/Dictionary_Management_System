namespace Dictionary_Management_System
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the dictionary, select an operation.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 103);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(73, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 97);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Location = new System.Drawing.Point(287, 143);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 97);
            this.btnView.TabIndex = 3;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Transparent;
            this.btnQuiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuiz.BackgroundImage")));
            this.btnQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuiz.Location = new System.Drawing.Point(510, 143);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(149, 97);
            this.btnQuiz.TabIndex = 4;
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-2, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 51);
            this.panel2.TabIndex = 5;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Panel panel2;
    }
}

