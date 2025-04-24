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
    public partial class FrmQuizSettings : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");
        bool isSelectedMode = false;
        bool isSelectedType = false;
        int total;
        int unknown;
        int time;

        public FrmQuizSettings()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu frm = new FrmMainMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmQuizSettings_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select Count(Word) From TblWord", conn);
            SqlCommand cmd2 = new SqlCommand("Select Count(Word) From TblWord where Unknown = 1", conn);

            total = (int)cmd.ExecuteScalar();
            unknown = (int)cmd2.ExecuteScalar();

            trackBar1.Maximum = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrackBarValue.Text = trackBar1.Value.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isSelectedMode && time != 0 && isSelectedType)
            {
                int wordNumber = Convert.ToInt32(lblTrackBarValue.Text);

                bool isRespondTurkish;
                if (rbtnTurkish.Checked)
                {
                    isRespondTurkish = true;
                }
                else
                {
                    isRespondTurkish = false;
                }

                bool isModeAll;
                if (rbtnAll.Checked)
                {
                    isModeAll = true;
                }
                else
                {
                    isModeAll = false;
                }

                FrmQuiz frm = new FrmQuiz(wordNumber, time, isRespondTurkish, isModeAll);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill the settings!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                trackBar1.Maximum = total;
                trackBar1.Value = total;
                lblTrackBarValue.Text = total.ToString();
                isSelectedMode = true;
            }
        }

        private void rbtnUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUnknown.Checked)
            {
                trackBar1.Maximum = unknown;
                trackBar1.Value = unknown;
                lblTrackBarValue.Text = unknown.ToString();
                isSelectedMode = true;
            }
        }

        private void mskTime_TextChanged(object sender, EventArgs e)
        {
            time = Convert.ToInt32(mskTime.Text);
        }

        private void rbtnTurkish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTurkish.Checked)
            {
                isSelectedType = true;
            }
        }

        private void rbtnEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEnglish.Checked)
            {
                isSelectedType = true;
            }
        }
    }
}
