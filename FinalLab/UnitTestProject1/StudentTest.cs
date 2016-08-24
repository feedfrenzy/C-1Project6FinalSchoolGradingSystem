using FinalLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinalLabTest
{


    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for sFName
        ///</summary>
        [TestMethod()]
        public void sFNameTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            string fName = ""; // TODO: Initialize to an appropriate value
            string lName = ""; // TODO: Initialize to an appropriate value
            string Major = ""; // TODO: Initialize to an appropriate value
            Student student = new Student(id, year, fName, lName, Major); // TODO: Initialize to an appropriate value
            string expected = "Yi"; // TODO: Initialize to an appropriate value
            string actual;
            student.sFName = expected;
            actual = student.sFName;
            Assert.AreEqual(expected, actual);
            //     Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sID
        ///</summary>
        [TestMethod()]
        public void sIDTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            string fName = ""; // TODO: Initialize to an appropriate value
            string lName = ""; // TODO: Initialize to an appropriate value
            string Major = ""; // TODO: Initialize to an appropriate value
            Student student = new Student(id, year, fName, lName, Major); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            student.sID = expected;
            actual = student.sID;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sLName
        ///</summary>
        [TestMethod()]
        public void sLNameTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            string fName = ""; // TODO: Initialize to an appropriate value
            string lName = ""; // TODO: Initialize to an appropriate value
            string Major = ""; // TODO: Initialize to an appropriate value
            Student student = new Student(id, year, fName, lName, Major); // TODO: Initialize to an appropriate value
            string expected = "Lin"; // TODO: Initialize to an appropriate value
            string actual;
            student.sLName = expected;
            actual = student.sLName;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sMajor
        ///</summary>
        [TestMethod()]
        public void sMajorTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            string fName = ""; // TODO: Initialize to an appropriate value
            string lName = ""; // TODO: Initialize to an appropriate value
            string Major = ""; // TODO: Initialize to an appropriate value
            Student student = new Student(id, year, fName, lName, Major); // TODO: Initialize to an appropriate value
            string expected = "IST"; // TODO: Initialize to an appropriate value
            string actual;
            student.sMajor = expected;
            actual = student.sMajor;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sYear
        ///</summary>
        [TestMethod()]
        public void sYearTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            string fName = ""; // TODO: Initialize to an appropriate value
            string lName = ""; // TODO: Initialize to an appropriate value
            string Major = ""; // TODO: Initialize to an appropriate value
            Student student = new Student(id, year, fName, lName, Major); // TODO: Initialize to an appropriate value
            int expected = 2016; // TODO: Initialize to an appropriate value
            int actual;
            student.sYear = expected;
            actual = student.sYear;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
namespace UnitTestProject1
{
    
    
    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for getPoints
        ///</summary>
        [TestMethod()]
        public void getPointsTest()
        {
            Student student = new Student(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            student.getPoints = expected;
            actual = student.getPoints;
            Assert.AreEqual(expected, actual);
         //   Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
