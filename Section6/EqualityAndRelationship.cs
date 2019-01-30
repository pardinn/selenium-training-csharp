using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class EqualityAndRelationship
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
        public void Number1_Is_Equal_Number2()
        {
            if (number1 == number2)
            {
                //this code only executes if condition is true
                Assert.IsTrue(number1 == number2);
            }
            Assert.IsFalse(number1 == number2);
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_Number2()
        {
            if(number1!=number2)
            {
                Assert.IsTrue(number1 != number2);
            }
        }

        [TestMethod]
        public void Number1_Greater_Than_Number2()
        {
            if (number1 > number2)
            {
                Assert.IsTrue(number1 > number2);
            }
        }

        [TestMethod]
        public void Number1_Greater_Than_Or_Equal_Number2()
        {
            if (number1 >= number2)
            {
                Assert.IsTrue(number1 >= number2);
            }
        }

        [TestMethod]
        public void Number2_Less_Than_Number1()
        {
            if (number2 < number1)
            {
                Assert.IsTrue(number2 < number1);
            }
        }

        [TestMethod]
        public void Number2_Less_Than_Or_Equal_Number1()
        {
            if (number2 <= number1)
            {
                Assert.IsTrue(number2 <= number1);
            }
        }
    }
}
