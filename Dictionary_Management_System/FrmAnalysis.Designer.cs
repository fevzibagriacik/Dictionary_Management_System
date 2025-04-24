namespace Dictionary_Management_System
{
    partial class FrmAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnalysis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meaningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısRightDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDictionaryManagementSystemDataSet3 = new Dictionary_Management_System.DbDictionaryManagementSystemDataSet3();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tblAnalysisTableAdapter = new Dictionary_Management_System.DbDictionaryManagementSystemDataSet3TableAdapters.TblAnalysisTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDictionaryManagementSystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(100, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(944, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.wordDataGridViewTextBoxColumn,
            this.meaningDataGridViewTextBoxColumn,
            this.ısRightDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblAnalysisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // meaningDataGridViewTextBoxColumn
            // 
            this.meaningDataGridViewTextBoxColumn.DataPropertyName = "Meaning";
            this.meaningDataGridViewTextBoxColumn.HeaderText = "Meaning";
            this.meaningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meaningDataGridViewTextBoxColumn.Name = "meaningDataGridViewTextBoxColumn";
            // 
            // ısRightDataGridViewCheckBoxColumn
            // 
            this.ısRightDataGridViewCheckBoxColumn.DataPropertyName = "IsRight";
            this.ısRightDataGridViewCheckBoxColumn.HeaderText = "IsRight";
            this.ısRightDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısRightDataGridViewCheckBoxColumn.Name = "ısRightDataGridViewCheckBoxColumn";
            // 
            // tblAnalysisBindingSource
            // 
            this.tblAnalysisBindingSource.DataMember = "TblAnalysis";
            this.tblAnalysisBindingSource.DataSource = this.dbDictionaryManagementSystemDataSet3;
            // 
            // dbDictionaryManagementSystemDataSet3
            // 
            this.dbDictionaryManagementSystemDataSet3.DataSetName = "DbDictionaryManagementSystemDataSet3";
            this.dbDictionaryManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(0, -4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 77);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tblAnalysisTableAdapter
            // 
            this.tblAnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1086, 599);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnalysis_FormClosing);
            this.Load += new System.EventHandler(this.FrmAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDictionaryManagementSystemDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReturn;
        private DbDictionaryManagementSystemDataSet3 dbDictionaryManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource tblAnalysisBindingSource;
        private DbDictionaryManagementSystemDataSet3TableAdapters.TblAnalysisTableAdapter tblAnalysisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meaningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRightDataGridViewCheckBoxColumn;
    }
}