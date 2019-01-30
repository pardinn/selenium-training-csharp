using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestLessons
    {
        public TestContext TestContext { get; set; }

        private static TestContext _testContext;

        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            _testContext = testContext;
        }

        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup]
        public static void MyClassCleanup() { }

        // Use TestInitialize to run code before running each test
        [TestInitialize]
        public void SetupTest()
        {
            Console.WriteLine(
                "TestContext.TestName='{0}' static _testContext.TestName='{1}'",
                TestContext.TestName,
                _testContext.TestName);
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void MyTestCleanup() { }

        [TestMethod]
        [Description("This is a description of the test")]
        //[ExpectedException(typeof(Exception))]
        public void Integers_Are_Equal()
        {
            int someNumber = 12;
            Assert.AreEqual(someNumber, 12, "These numbers are not equal");
        }

        [TestMethod]
        public void Integers_Are_Not_Equal()
        {
            int someNumber = 12;
            Assert.AreNotEqual(someNumber, 10);
        }

        [TestMethod]
        public void String_Ends_With()
        {
            string word = "testing";
            StringAssert.EndsWith(word, "ing", "This test only passes if the string ends in ing");
        }

        [TestMethod]
        [TestCategory("Nightly"),TestCategory("Weekly")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Nightly")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\Data.csv", "Data#csv",DataAccessMethod.Sequential)]
        public void DataTestingCSV()
        {
            // Arrange
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            string message = TestContext.DataRow[3].ToString();

            // Act
            var actual = Math.Min(a, b);

            // Assert
            Assert.AreEqual(expected, actual, message);
        }
    }
}
