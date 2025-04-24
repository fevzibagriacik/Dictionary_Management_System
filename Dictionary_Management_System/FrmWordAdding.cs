using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Dictionary_Management_System
{
    public partial class FrmWordAdding : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");
        bool isKnown = false;

        public FrmWordAdding()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtWord.Text.Length > 0 && txtMean.Text.Length > 0)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert Into TblWord (Word, Meaning, Unknown, IsSelected) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtWord.Text);
                cmd.Parameters.AddWithValue("@p2", txtMean.Text);
                cmd.Parameters.AddWithValue("@p3", !isKnown);
                cmd.Parameters.AddWithValue("@p4", false);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Word is added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtWord.Text = "";
                txtMean.Text = "";
                rbtnKnown.Checked = false;
                rbtnUnknown.Checked = false;
                txtWord.Focus();
            }
            else
            {
                MessageBox.Show("Please fill the options!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmWordAdding_Load(object sender, EventArgs e)
        {

        }

        private void rbtnKnown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKnown.Checked)
            {
                isKnown = true;
            }
        }

        private void rbtnUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUnknown.Checked)
            {
                isKnown = false;
            }
        }
    }
}
