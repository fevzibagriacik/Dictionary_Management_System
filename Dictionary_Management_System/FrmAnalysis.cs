using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dictionary_Management_System
{
    public partial class FrmAnalysis : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");

        public FrmAnalysis()
        {
            InitializeComponent();
        }
            
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmAnalysis_Load(object sender, EventArgs e)
        {
            this.tblAnalysisTableAdapter.Fill(this.dbDictionaryManagementSystemDataSet3.TblAnalysis);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
