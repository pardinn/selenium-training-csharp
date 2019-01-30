using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public void String_Ends_With_E()
        {
            string givenString = "Teste";
            StringAssert.EndsWith(givenString, "e");
        }
        [TestMethod]
        public void Add_Two_Int_Get_24()
        {
            int number1 = 10;
            int number2 = 14;
            int result = number1 + number2;
            Assert.AreEqual(24, result, $"The sum of {number1} + {number2} is not equal to 24");
        }

        [TestMethod]
        public void Compare_Two_Lists()
        {
            List<int> list1 = new List<int> { 5, 10 };
            List<int> list2 = new List<int> { 5, 10 };
            CollectionAssert.AreEqual(list1, list2);
        }
    }
}
