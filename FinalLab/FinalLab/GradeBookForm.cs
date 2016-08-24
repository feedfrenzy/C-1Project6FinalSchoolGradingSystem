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
    public partial class GradeBookForm : Form
    {

        private OleDbConnection connection = new OleDbConnection();

        public GradeBookForm()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                            Data Source=../../Database/LabDatabase.accdb;
                                            Persist Security Info=False;";
        }

        private void GradeBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from Student";
                command.CommandText = query;

                OleDbDataAdapter nData = new OleDbDataAdapter(command);
                DataTable nTable = new DataTable();

                nData.Fill(nTable);
                GridGrade.DataSource = nTable;

                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doesn't work!" + ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorForm nProfessor = new ProfessorForm();
            nProfessor.Show();
        }
    }
}
