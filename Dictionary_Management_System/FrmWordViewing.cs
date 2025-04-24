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

namespace Dictionary_Management_System
{
    public partial class FrmWordViewing : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");

        public FrmWordViewing()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmWordViewing_Load(object sender, EventArgs e)
        {
            this.tblWordTableAdapter.Fill(this.dbDictionaryManagementSystemDataSet2.TblWord);

            conn.Open();

            SqlCommand cmd = new SqlCommand("Select Count(Word) From TblWord", conn);
            SqlCommand cmd2 = new SqlCommand("Select Count(Word) From TblWord where Unknown = 1", conn);

            int total = (int)cmd.ExecuteScalar();
            int unknown = (int)cmd2.ExecuteScalar();

            lblTotal.Text = total.ToString();
            lblUnknown.Text = unknown.ToString();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "Select * From TblWord where Unknown=1 And Word like @p1 + '%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@p1", txtFind.Text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            else
            {
                using (SqlConnection conn1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True"))
                {
                    conn1.Open();

                    string query = "Select * From TblWord where Word like @p1 + '%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn1))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@p1", txtFind.Text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string word = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string meaning = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                bool known = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                FrmWordDetail frm = new FrmWordDetail(word, meaning, id, known);
                frm.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select * From TblWord Where Unknown=1", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource= dt;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From TblWord", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
