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
    public partial class FrmQuiz : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbDictionaryManagementSystem;Integrated Security=True");

        int wordNumber;
        int originalTime;
        int time;
        bool isRespondTurkish;
        bool isModeAll;
        int questionNo = 0;
        int trueNumber;
        int falseNumber;
        bool isRight;
        string currentWord;
        string currentMeaning;
        int currentWordID;
        public FrmQuiz(int wordNumber, int time, bool isRespondTurkish, bool isModeAll)
        {
            InitializeComponent();

            this.wordNumber = wordNumber;
            this.originalTime = time;
            this.isRespondTurkish = isRespondTurkish;
            this.isModeAll = isModeAll;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            UnSelected();
            time = originalTime;
            lblTime.Text = time.ToString();
            timer1.Start();
            questionNo++;
            lblQuestionNo.Text = questionNo.ToString();

            CenterRichTextBoxText(richTextBox1);

            GenerateRandomWord();
        }

        public void GenerateRandomWord()
        {
            Finish();

            conn.Open();

            if (isRespondTurkish)
            {
                if (isModeAll)
                {
                    SqlCommand cmd = new SqlCommand("Select Top 1 * From TblWord Where IsSelected=0 Order By NewID()", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        currentWord = dr["Word"].ToString();
                        richTextBox1.Text = currentWord;
                        currentMeaning = dr["Meaning"].ToString();
                        currentWordID = Convert.ToInt32(dr["ID"]);
                    }
                    
                    dr.Close();
                    Selected();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select Top 1 * From TblWord Where IsSelected=0 And Unknown='True' Order By NewID() ", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        currentWord = dr["Word"].ToString();
                        richTextBox1.Text = currentWord;
                        currentMeaning = dr["Meaning"].ToString();
                        currentWordID = Convert.ToInt32(dr["ID"]);
                    }
                    
                    dr.Close();
                    Selected();
                }
            }
            else
            {
                if (isModeAll)
                {
                    SqlCommand cmd = new SqlCommand("Select Top 1 * From TblWord Where IsSelected=0 Order By NewID()", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        currentWord = dr["Meaning"].ToString();
                        richTextBox1.Text = currentWord;
                        currentMeaning = dr["Word"].ToString();
                        currentWordID = Convert.ToInt32(dr["ID"]);
                    }
                    
                    dr.Close();
                    Selected();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select Top 1 * From TblWord Where IsSelected=0 And Unknown='True' Order By NewID()", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        currentWord = dr["Meaning"].ToString();
                        richTextBox1.Text = currentWord;
                        currentMeaning = dr["Word"].ToString();
                        currentWordID = Convert.ToInt32(dr["ID"]);
                    }
                    
                    dr.Close();
                    Selected();
                }
            }

            conn.Close();
        }

        private void CenterRichTextBoxText(RichTextBox rtb)
        {
            rtb.SelectAll();
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void AddWordAnalysisTable(string word, string meaning, bool isRight)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert Into TblAnalysis (Word, Meaning, IsRight, ConnID) values (@p1, @p2, @p3, @p4)", conn);
            cmd.Parameters.AddWithValue("@p1", word);
            cmd.Parameters.AddWithValue("@p2", meaning);
            cmd.Parameters.AddWithValue("@p3", isRight);
            cmd.Parameters.AddWithValue("@p4", currentWordID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtAnswer.Text, currentMeaning, true) == 0)
            {
                True();
                AddWordAnalysisTable(currentWord, currentMeaning, true);
                GenerateRandomWord();
            }
            else
            {
                False();
                AddWordAnalysisTable(currentWord, currentMeaning, false);
                GenerateRandomWord();
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            False();
            AddWordAnalysisTable(currentWord, currentMeaning, false);
            GenerateRandomWord();
        }

        public void Reset()
        {
            time = originalTime;
            lblTime.Text = time.ToString();
            txtAnswer.Text = "";
            txtAnswer.Focus();
        }

        public void True()
        {
            Reset();
            questionNo++;
            lblQuestionNo.Text = questionNo.ToString();
            trueNumber++;
            lblTrue.Text = trueNumber.ToString();
        }

        public void False()
        {
            Reset();
            questionNo++;
            lblQuestionNo.Text = questionNo.ToString();
            falseNumber++;
            lblFalse.Text = falseNumber.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = time.ToString();

            if(time <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time out!");
                GoAnalysisPage();
            }
        }

        public void GoAnalysisPage()
        {
            timer1.Stop();
            FrmAnalysis frm = new FrmAnalysis();
            frm.Show();
            this.Hide();
        }

        public void Finish()
        {
            if(questionNo > wordNumber)
            {
                GoAnalysisPage();
            }
            else
            {
                return;
            }
        }

        public void Selected()
        {
            Console.WriteLine(currentWordID.ToString());
            SqlCommand cmd1 = new SqlCommand("Update TblWord Set IsSelected = 1 Where ID=@p1", conn);
            cmd1.Parameters.AddWithValue("@p1", currentWordID);
            cmd1.ExecuteNonQuery();
        }

        public void UnSelected()
        {
            conn.Open();

            SqlCommand unSelect = new SqlCommand("Update TblWord Set IsSelected = 0", conn);
            unSelect.ExecuteNonQuery();

            conn.Close();
        }
    }
}
