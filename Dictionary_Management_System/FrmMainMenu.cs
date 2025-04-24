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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmWordAdding frm = new FrmWordAdding();
            frm.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FrmWordViewing frm = new FrmWordViewing();
            frm.Show();
            this.Hide();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            FrmQuizSettings frm = new FrmQuizSettings();
            frm.Show();
            this.Hide();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete From TblAnalysis", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
