using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FirstProject
{
    public partial class MultipleChoiceGame : Form
    { 
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int score = 0;
        int currentQuestion = 0;
        public string checkAnswer()
        {
            if (rdoAnswer1.Checked)
                return rdoAnswer1.Text.ToString();
            if (rdoAnswer2.Checked)
                return rdoAnswer2.Text.ToString();
            if (rdoAnswer3.Checked)
                return rdoAnswer3.Text.ToString();
            if (rdoAnswer4.Checked)
                return rdoAnswer4.Text.ToString();
            return "";
        }

        public void connectDB()
        {

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT TOP 10 * FROM Question ORDER BY NEWID()");
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Visible = false;
            btnRestart.Visible = false;
            grpSingleAnswers.Visible = false;
            pictureBox1.Width = 406;
            pictureBox1.Height = 209;
            pictureBox1.Left = 250;
            btnSubmit.Visible = false;
            btnQuit.Visible = false;
            txtQuestion.Visible = false;
            rdoAnswer1.Visible = false;
            rdoAnswer2.Visible = false;
            rdoAnswer3.Visible = false;
            rdoAnswer4.Visible = false;
            btnStart.Visible = true;
            btnStart.Enabled = true;
            lblQuestion.Visible = false;
            
        }

        public MultipleChoiceGame()
        {
            InitializeComponent();
            connectDB();
        }


            
        private void btnStart_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            txtQuestion.Text = dt.Rows[0]["Question"].ToString();
            rdoAnswer1.Text = dt.Rows[0]["Ans1"].ToString();
            rdoAnswer2.Text = dt.Rows[0]["Ans2"].ToString();
            rdoAnswer3.Text = dt.Rows[0]["Ans3"].ToString();
            rdoAnswer4.Text = dt.Rows[0]["Ans4"].ToString();

            lblQuestion.Text = currentQuestion.ToString() + "/10";

            if (currentQuestion <= 10)
            {
                lblQuestion.Visible = true;
                txtQuestion.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.Width = 272;
                pictureBox1.Height = 124;
                pictureBox1.Left = 312;
                lblScore.Visible = true;
                btnRestart.Visible = true;
                grpSingleAnswers.Visible = true;
                rdoAnswer1.Visible = true;
                rdoAnswer2.Visible = true;
                rdoAnswer3.Visible = true;
                rdoAnswer4.Visible = true;
                btnQuit.Visible = true;
                btnStart.Visible = false;
                btnStart.Enabled = false;
                btnSubmit.Visible = true;
                btnSubmit.Enabled = true;
            }

            else
            {
                lblQuestion.Visible = false;
                lblScore.Visible = false;
                btnRestart.Visible = false;
                grpSingleAnswers.Visible = false;
                pictureBox1.Visible = false;
                txtQuestion.Visible = false;
                rdoAnswer1.Visible = false;
                rdoAnswer2.Visible = false;
                rdoAnswer3.Visible = false;
                rdoAnswer4.Visible = false;
                btnStart.Visible = false;
                btnStart.Enabled = false;
                btnSubmit.Visible = false;
                btnQuit.Visible = false;
                MessageBox.Show("Finished! You scored " + score);
                Close();
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkAnswer().Equals(dt.Rows[0]["CorrectAns"].ToString()))
            {
                MessageBox.Show("Correct!");
                btnSubmit.Enabled = false;
                btnSubmit.Visible = false;
                btnStart.Enabled = true;
                btnStart.Visible = true;
                btnStart.Text = "Next";
                score++;
                lblScore.Text = "Score: " + score.ToString();


            }

            else
            {
                MessageBox.Show("Incorrect!");
                btnSubmit.Visible = false;
                btnSubmit.Enabled = false;
                btnStart.Visible = true;
                btnStart.Enabled = true;
                btnStart.Text = "Next";
                score--;
                lblScore.Text = "Score: " + score.ToString();
            }





        }
        private void QuestionAnswer_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpSingleAnswers_Enter(object sender, EventArgs e)
        {

        }

        private void rdoAnswer1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
            
        }
    }
}

        

