using FinalLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinalLabTest
{


    /// <summary>
    ///This is a test class for QuizTest and is intended
    ///to contain all QuizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QuizTest
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
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            int dData = 0; // TODO: Initialize to an appropriate value
            Quiz quiz = new Quiz(dData); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            quiz.ID = expected;
            actual = quiz.ID;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Professor
        ///</summary>
        [TestMethod()]
        public void ProfessorTest()
        {
            int dData = 0; // TODO: Initialize to an appropriate value
            Quiz quiz = new Quiz(dData); // TODO: Initialize to an appropriate value
            string expected = "James"; // TODO: Initialize to an appropriate value
            string actual;
            quiz.Professor = expected;
            actual = quiz.Professor;
            Assert.AreEqual(expected, actual);
            //    Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Question
        ///</summary>
        [TestMethod()]
        public void QuestionTest()
        {
            int dData = 0; // TODO: Initialize to an appropriate value
            Quiz quiz = new Quiz(dData); // TODO: Initialize to an appropriate value
            string expected = "6+9"; // TODO: Initialize to an appropriate value
            string actual;
            quiz.Question = expected;
            actual = quiz.Question;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Answer
        ///</summary>
        [TestMethod()]
        public void AnswerTest()
        {
            int dData = 0; // TODO: Initialize to an appropriate value
            Quiz quiz = new Quiz(dData); // TODO: Initialize to an appropriate value
            string expected = "15"; // TODO: Initialize to an appropriate value
            string actual;
            quiz.Answer = expected;
            actual = quiz.Answer;
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
