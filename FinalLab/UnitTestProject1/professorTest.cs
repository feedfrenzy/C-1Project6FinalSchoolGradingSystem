using FinalLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinalLabTest
{


    /// <summary>
    ///This is a test class for professorTest and is intended
    ///to contain all professorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class professorTest
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
        ///A test for getClass
        ///</summary>
        [TestMethod()]
        public void getClassTest()
        {
            int ID = 1; // TODO: Initialize to an appropriate value
            string fN = "Chris"; // TODO: Initialize to an appropriate value
            string lN = "Pascucci"; // TODO: Initialize to an appropriate value
            string classN = "CIS3309"; // TODO: Initialize to an appropriate value
            professor Pro = new professor(ID, fN, lN, classN); // TODO: Initialize to an appropriate value
            string expected = "CIS3309"; // TODO: Initialize to an appropriate value
            string actual;
            Pro.getClass = expected;
            actual = Pro.getClass;
            Assert.AreEqual(expected, actual);
            //  Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getID
        ///</summary>
        [TestMethod()]
        public void getIDTest()
        {
            int ID = 1; // TODO: Initialize to an appropriate value
            string fN = "Chris"; // TODO: Initialize to an appropriate value
            string lN = "Pascucci"; // TODO: Initialize to an appropriate value
            string classN = "CIS3309"; // TODO: Initialize to an appropriate value
            professor Pro = new professor(ID, fN, lN, classN); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            Pro.getID = expected;
            actual = Pro.getID;
            // Assert.AreEqual(expected, actual); Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getfirstName
        ///</summary>
        [TestMethod()]
        public void getfirstNameTest()
        {
            int ID = 1; // TODO: Initialize to an appropriate value
            string fN = "Chris"; // TODO: Initialize to an appropriate value
            string lN = "Pascucci"; // TODO: Initialize to an appropriate value
            string classN = "CIS3309"; // TODO: Initialize to an appropriate value
            professor Pro = new professor(ID, fN, lN, classN); // TODO: Initialize to an appropriate value
            string expected = "Chris"; // TODO: Initialize to an appropriate value
            string actual;
            Pro.getfirstName = expected;
            actual = Pro.getfirstName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getlastName
        ///</summary>
        [TestMethod()]
        public void getlastNameTest()
        {
            int ID = 1; // TODO: Initialize to an appropriate value
            string fN = "Chris"; // TODO: Initialize to an appropriate value
            string lN = "Pascucci"; // TODO: Initialize to an appropriate value
            string classN = "CIS3309"; // TODO: Initialize to an appropriate value
            professor Pro = new professor(ID, fN, lN, classN); // TODO: Initialize to an appropriate value
            string expected = "Pascucci"; // TODO: Initialize to an appropriate value
            string actual;
            Pro.getlastName = expected;
            actual = Pro.getlastName;
            Assert.AreEqual(expected, actual);
        }
    }
}
