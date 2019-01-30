﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegerOperations
{
    [TestClass]
    public class IntegerOperations
    {
        //variables to hold the two integer values
        static int number1;
        static int number2;

        [ClassInitialize]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            int difference = number1 - number2;
            Assert.AreEqual(5, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = number1 * number2;
            Assert.AreEqual(50, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            int division = number1 / number2;
            Assert.AreEqual(2, division);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int mod = number1 % number2;
            Assert.AreEqual(0, mod);
        }
    }
}
