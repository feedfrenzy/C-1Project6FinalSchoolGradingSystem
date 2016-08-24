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
    public partial class QuizForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        private int ans = 0;

        Student newStudent = new Student();

        public QuizForm()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                            Data Source=../../Database/LabDatabase.accdb;
                                            Persist Security Info=False;";
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from Student";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboStudent.Items.Add(reader["FName"].ToString());
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

                string query = "select * from Quiz";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboQuestions.Items.Add(reader["Questions"].ToString());
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doesn't work!" + ex);
            }
        }

        private void btnAnswerEnter_Click(object sender, EventArgs e)
        {
            int t;

            if (comboQuestions.Text == "")
            {
                MessageBox.Show("Please select your question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboStudent.Text == "")
            {
                MessageBox.Show("Please select a student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAnswer.Text == "")
            {
                MessageBox.Show("Answer can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(txtAnswer.Text, out t) == false)
            {
                MessageBox.Show("Answer can only be interger!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //int saveIndex = comboQuestions.SelectedIndex;
                //// check points

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    int answer = Convert.ToInt32(txtAnswer.Text);
                    string question = comboQuestions.Text;
                    string student = comboStudent.Text;

                    newStudent.sFName = student;


                string query = "select * from Quiz where Answer ='" + answer + "'";


                        command.CommandText = query;

                        OleDbDataReader reader = command.ExecuteReader();

                        int count = 0;

                        while (reader.Read())
                        {
                            count++;
                        }

                        connection.Close();

                        if (count >= 1)
                        {
                            MessageBox.Show("Corrected!!");

                            ans++;

                            newStudent.getPoints = ans;

                            lblpointShow.Text = Convert.ToString(ans);

                            if (comboQuestions.Items.Count == 0)
                            {
                                MessageBox.Show("You are done with all your quiz!", "", MessageBoxButtons.OK);
                                comboQuestions.Items.Remove(comboQuestions.SelectedItem);
                                txtAnswer.Text = "";
                                this.Hide();
                                LoginForm back = new LoginForm();
                                back.Show();
                            }

                            try
                            {
                                connection.Open();

                                string queryUpdate = "update Student set QuizPoints= '" + newStudent.getPoints + "' where FName ='"+newStudent.sFName+"'";

                                command.CommandText = queryUpdate;

                                command.ExecuteNonQuery();



                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Points no good!" + ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Answer!");
                        }

                        comboQuestions.Items.Remove(comboQuestions.SelectedItem);
                        txtAnswer.Text = "";

                    }
                
                catch (Exception ex)
                {

                    MessageBox.Show("Doesn't work!" + ex);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }
    }
}
