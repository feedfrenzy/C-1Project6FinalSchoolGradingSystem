using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalLab
{
    public partial class ProfessorForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        system Data = new system();

        public ProfessorForm()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                            Data Source=../../Database/LabDatabase.accdb;
                                            Persist Security Info=False;";
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from Quiz";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboDeleteQuiz.Items.Add(reader["QuizID"].ToString());
                }

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Doesn't work!" + ex);
            }



            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from Professor";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboProfessor.Items.Add(reader["FName"].ToString());
                }

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Doesn't work!" + ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            int interger;


            if (comboProfessor.Text == "")
            {
                MessageBox.Show("Please Select a Professor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.TryParse(txtAnswers.Text, out interger) == false)
            {
                MessageBox.Show("Answer must be intergers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int NOM;

                bool tryOut = int.TryParse(txtQuestionID.Text, out NOM);

                if (tryOut == true)
                {
                    int qID = Convert.ToInt32(txtQuestionID.Text);

                    string qQuestions = txtQuestions.Text;

                    string qAnswers = txtAnswers.Text;

                    string qProfessor = comboProfessor.Text;

                    Quiz pManage = new Quiz(qID, qQuestions, qAnswers, qProfessor);
                    int rData = Data.addQuiz(pManage); // calling system class


                    if (rData == 1)
                    {
                        MessageBox.Show("Quiz Saved!");
                        txtQuestionID.Text = "";
                        txtQuestions.Text = "";
                        txtAnswers.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Duplicate ID Number!!, Please restart this form again to enter correct one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID Must be interger!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int interger;


            if (comboProfessor.Text == "")
            {
                MessageBox.Show("Please Select a Professor!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(txtAnswers.Text, out interger) == false)
            {
                MessageBox.Show("Answer must be intergers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int NOM;

                bool tryOut = int.TryParse(txtQuestionID.Text, out NOM);

                if (tryOut == true)
                {

                    int qID = Convert.ToInt32(txtQuestionID.Text);
                    string qQuestions = txtQuestions.Text;
                    string qAnswers = txtAnswers.Text;
                    string qProfessor = comboProfessor.Text;


                    Quiz pManage = new Quiz(qID, qQuestions, qAnswers, qProfessor);
                    int rData = Data.updateQuiz(pManage);

                    if (rData == 1)
                    {
                        MessageBox.Show("Update Saved!");
                        txtQuestionID.Text = "";
                        txtQuestions.Text = "";
                        txtAnswers.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Doesn't work!");
                    }
                }
                else
                {
                    MessageBox.Show("ID Must be interger!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboDeleteQuiz.Text == "")
            {
                MessageBox.Show("Please Select the quiz id to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int delete = Convert.ToInt32(comboDeleteQuiz.Text);

                Quiz pManage = new Quiz(delete);
                int rData = Data.deleteQuiz(pManage);

                if (rData == 1)
                {
                    MessageBox.Show("Quiz Deleted!");

                    comboDeleteQuiz.Items.Remove(comboDeleteQuiz.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Doesn't work!");
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeBookForm grade = new GradeBookForm();
            grade.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm nLogin = new LoginForm();
            nLogin.Show();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProfessorForm nP = new NewProfessorForm();
            nP.Show();
        }
    }
}
