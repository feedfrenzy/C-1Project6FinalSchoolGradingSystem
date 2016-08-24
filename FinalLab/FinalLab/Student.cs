using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    public class Student
    {
        private int StudentID;
        private int StudentYear;
        private string FirstName;
        private string LastName;
        private string StudentMajor;
        private int Points = 0;


        //public Student(string name)
        //{
        //    FirstName = name;
        //}

        public Student()
        {
        }

        public Student(int id, int year, string fName, string lName, string Major)
        {
            StudentID = id;
            StudentYear = year;
            FirstName = fName;
            LastName = lName;
            StudentMajor = Major;
        }

        public Student (int p)
        {
            Points = p;
        }

        public int sID
        {
            set { StudentID = value; }
            get { return StudentID; }
        }

        public int sYear
        {
            set { StudentYear = value; }
            get { return StudentYear; }
        }

        public string sFName
        {
            set { FirstName = value; }
            get { return FirstName; }
        }

        public string sLName
        {
            set { LastName = value; }
            get { return LastName; }
        }

        public string sMajor
        {
            set { StudentMajor = value; }
            get { return StudentMajor; }
        }

        public int getPoints
        {
            set { Points = value; }
            get { return Points; }
        }

        //public int addStudent(Student nStudent)
        //{
        //    try
        //    {
        //        connection.ConnectionString = c;

        //        connection.Open();

        //        OleDbCommand command = new OleDbCommand();

        //        command.Connection = connection;

        //        string query = "insert into Student ([StudentID],[FName],[LName],[Major],[ClassOf]) values('" + nStudent.sID + "','" + nStudent.sFName + "','" + nStudent.sLName + "','" + nStudent.sMajor + "','" + nStudent.sYear + "')"; ;

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
