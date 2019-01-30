using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FloatingPointOperations
{
    [TestClass]
    public class FloatingPointOperations
    {
        //variables to hold the two integer values
        static double number1;
        static double number2;

        [ClassInitialize]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5, sum);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(5.5, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double product = number1 * number2;
            Assert.AreEqual(52.5, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            double division = number1 / number2;
            Assert.AreEqual(2.1, division);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            double mod = number1 % number2;
            Assert.AreEqual(0.5, mod);
        }
    }
}
