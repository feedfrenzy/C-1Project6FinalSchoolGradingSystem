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
    public partial class CurrentStudentForm : Form
    {

        private OleDbConnection connection = new OleDbConnection();

        public CurrentStudentForm()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                            Data Source=../../Database/LabDatabase.accdb;
                                            Persist Security Info=False;";
        }

        private void CurrentStudentForm_Load(object sender, EventArgs e)
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
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            if (comboStudent.Text == "")
            {
                MessageBox.Show("Please Select a student!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                QuizForm newQuiz = new QuizForm();
                newQuiz.Show();

                //Student name = new Student(comboStudent.Text);


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm bLogin = new LoginForm();
            bLogin.Show();
        }


    }
}
