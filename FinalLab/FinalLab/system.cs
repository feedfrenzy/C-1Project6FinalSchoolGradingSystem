using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FinalLab
{
   public class system
    {
        private string c = @"Provider=Microsoft.ACE.OLEDB.12.0;
                             Data Source=../../Database/LabDatabase.accdb;
                             Persist Security Info=False;";

        OleDbConnection connection = new OleDbConnection();


        public int addQuiz(Quiz qQuiz)
        {
            try
            {
                connection.ConnectionString = c;

                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "insert into Quiz ([QuizID],[Questions],[Answer],[ProfessorName]) values('" + qQuiz.ID + "','" + qQuiz.Question + "','" + qQuiz.Answer + "','" + qQuiz.Professor + "')";

                command.CommandText = query;

                command.ExecuteNonQuery();

                connection.Close();

                return 1;
            }
            catch (Exception ex)
            {
                string test = "Doesnt Work" + ex;
                return -1;
            }
        }

        public int updateQuiz(Quiz qQuiz)
        {
            try
            {
                connection.ConnectionString = c;

                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "update Quiz set Questions='" + qQuiz.Question + " ',Answer='" + qQuiz.Answer + " ',ProfessorName='" + qQuiz.Professor + "'where QuizID =" + qQuiz.ID + "";

                command.CommandText = query;

                command.ExecuteNonQuery();

                connection.Close();

                return 1;
            }
            catch (Exception ex)
            {
                string test = "Doesnt Work" + ex;
                return -1;
            }
        }

        public int deleteQuiz(Quiz qQuiz)
        {
            try
            {
                connection.ConnectionString = c;

                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "delete from Quiz where QuizID=" + qQuiz.dID + "";

                command.CommandText = query;

                command.ExecuteNonQuery();

                connection.Close();

                return 1;
            }
            catch (Exception ex)
            {
                string test = "Doesnt Work" + ex;
                return -1;
            }
        }

        public int addStudent(Student nStudent)
        {
            try
            {
                connection.ConnectionString = c;

                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "insert into Student ([StudentID],[FName],[LName],[Major],[ClassOf]) values('" + nStudent.sID + "','" + nStudent.sFName + "','" + nStudent.sLName + "','" + nStudent.sMajor + "','" + nStudent.sYear + "')"; ;

                command.CommandText = query;

                command.ExecuteNonQuery();

                connection.Close();

                return 1;
            }
            catch (Exception ex)
            {
                string test = "Doesnt Work" + ex;
                return -1;
            }

        }

        public int addProfessor(professor nProfessor)
        {
            try
            {
                connection.ConnectionString = c;

                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "insert into Professor ([ProfessorID],[FName],[LName],[ClassTeaching]) values('" + nProfessor.getID + "','" + nProfessor.getfirstName + "','" + nProfessor.getlastName + "','" + nProfessor.getClass + "')";

                command.CommandText = query;

                command.ExecuteNonQuery();

                connection.Close();

                return 1;
            }
            catch (Exception ex)
            {
                string test = "Doesnt Work" + ex;
                return -1;
            }
        }

    }
}
