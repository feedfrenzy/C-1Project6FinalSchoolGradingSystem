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
    public partial class LoginForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public LoginForm()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                             Data Source=../../Database/LabDatabase.accdb;
                                             Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
              
                checkConnection.Text = "Connection Successful!";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Fail!"+ ex);
            }

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudentForm student = new NewStudentForm();
            student.Show();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorForm professor = new ProfessorForm();
            professor.Show();
        }

        private void btnCurrentStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizForm cStudent = new QuizForm();
            cStudent.Show();
        }
    }
}
