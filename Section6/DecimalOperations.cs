using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalOperations
{
    [TestClass]
    public class DecimalOperations
    {
        //variables to hold the two integer values
        static decimal number1;
        static decimal number2;

        [ClassInitialize]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5M;
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5M, sum);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            decimal difference = number1 - number2;
            Assert.AreEqual(5.5M, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal product = number1 * number2;
            Assert.AreEqual(52.5M, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            decimal division = number1 / number2;
            Assert.AreEqual(2.1M, division);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            decimal mod = number1 % number2;
            Assert.AreEqual(0.5M, mod);
        }
    }
}
