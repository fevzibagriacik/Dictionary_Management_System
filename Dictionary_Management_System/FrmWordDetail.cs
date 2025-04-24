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
using System.Diagnostics;

namespace Dictionary_Management_System
{
    public partial class FrmWordDetail : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");
        int ID;
        bool isNewKnown;
        bool knownValue;

        public FrmWordDetail(string word, string meaning, int id, bool isKnown)
        {
            InitializeComponent();

            txtWord.Text = word;
            txtMean.Text = meaning;
            ID = id;
            isNewKnown = isKnown;
        }

        private void FrmWordDetail_Load(object sender, EventArgs e)
        {
            if (isNewKnown)
            {
                rbtnKnown.Checked = true;
            }
            else
            {
                rbtnUnknown.Checked = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmWordViewing frm = new FrmWordViewing();
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update TblWord Set Word=@p1, Meaning=@p2, Unknown=@p4 where ID=@p3", conn);
            cmd.Parameters.AddWithValue("@p1", txtWord.Text);
            cmd.Parameters.AddWithValue("@p2", txtMean.Text);
            cmd.Parameters.AddWithValue("@p3", ID);
            cmd.Parameters.AddWithValue("@p4", knownValue);
            
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Word is updated.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine(knownValue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete the word?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Delete From TblWord where ID = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", ID);

                cmd.ExecuteNonQuery();

                conn.Close();

                FrmWordViewing frm = new FrmWordViewing();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void rbtnKnown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKnown.Checked)
            {
                knownValue = false;
            }
        }

        private void rbtnUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUnknown.Checked)
            {
                knownValue = true;
            }
        }
    }
}
