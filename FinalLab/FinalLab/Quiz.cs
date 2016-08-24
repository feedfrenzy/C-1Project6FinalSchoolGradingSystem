using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
   public class Quiz
    {
        private int QuizID;
        private string Questions;
        private string Answers;
        private string Professors;
        private int deleteID;

        public Quiz(int id, string q, string a, string professor)
        {
            QuizID = id;
            Questions = q;
            Answers = a;
            Professors = professor;
        }

        public Quiz(int dData)
        {
            deleteID = dData;
        }

        public int ID
        {
            set { QuizID = value; }
            get { return QuizID; }
        }

        public int dID
        {
            set { deleteID = value; }
            get { return deleteID; }
        }

        public string Question
        {
            set { Questions = value; }
            get { return Questions; }
        }

        public string Answer
        {
            set { Answers = value; }
            get { return Answers; }
        }

        public string Professor
        {
            set { Professors = value; }
            get { return Professors; }
        }

        //public int addQuiz(Quiz qQuiz)
        //{
        //    try
        //    {
        //        connection.ConnectionString = c;

        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand();

        //        command.Connection = connection;

        //        string query = "insert into Quiz ([QuizID],[Questions],[Answer],[ProfessorName]) values('" + qQuiz.ID + "','" + qQuiz.Question + "','" + qQuiz.Answer + "','" + qQuiz.Professor + "')";

        //        command.CommandText = query;

        //        command.ExecuteNonQuery();

        //        connection.Close();

        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        string test = "Doesnt Work" + ex;
        //        return -1;
        //    }
        //}

        //public int updateQuiz(Quiz qQuiz)
        //{
        //    try
        //    {
        //        connection.ConnectionString = c;

        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand();

        //        command.Connection = connection;

        //        string query = "update Quiz set Questions='" + qQuiz.Question + " ',Answer='" + qQuiz.Answer + " ',ProfessorName='" + qQuiz.Professor + "'where QuizID =" + qQuiz.ID + "";

        //        command.CommandText = query;

        //        command.ExecuteNonQuery();

        //        connection.Close();

        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        string test = "Doesnt Work" + ex;
        //        return -1;
        //    }
        //}

        //public int deleteQuiz(Quiz qQuiz)
        //{
        //    try
        //    {
        //        connection.ConnectionString = c;

        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand();

        //        command.Connection = connection;

        //        string query = "delete from Quiz where QuizID=" + qQuiz.dID + "";

        //        command.CommandText = query;

        //        command.ExecuteNonQuery();

        //        connection.Close();

        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        string test = "Doesnt Work" + ex;
        //        return -1;
        //    }
        //}
    }
}
