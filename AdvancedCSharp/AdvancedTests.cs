using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AdvancedCSharp
{
    [TestClass]
    public class AdvancedTests
    {
        [TestMethod]
        public void ImplicitCasting()
        {
            Mammal mammal = new Cat();
            Animal animal = new Cat();
        }

        [TestMethod]
        public void ExplicitCasting()
        {
            double dPi = 3.1415926535;

            int iValue = (int)dPi;
            Console.WriteLine(iValue);
        }

        [TestMethod]
        public void BoxingCasting()
        {
            double dPi = 3.1415926535;
            object oPi = (object)dPi;
            Console.WriteLine(oPi);
        }

        [TestMethod]
        public void UnboxingCasting()
        {
            double dPi = 3.1415926535;
            object oPi = (object)dPi;

            dPi = (double)oPi;
            Console.WriteLine(dPi);
        }

        [TestMethod]
        public void DelegateTest()
        {
            DelegateDemo.Main();
        }

        delegate int del(int i);
        [TestMethod]
        public void LambdaTest()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(25, j);
        }

        [TestMethod]
        public void ListLambdaTest()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]
        public void StatementLambdaTest()
        {
            TestDelegate del = n =>
            {
                string s = n + " World";
                Console.WriteLine(s);
            };
            del("Hello");
        }

        [TestMethod]
        [Description("Regular Expression Example")]
        public void MatchEmail()
        {
            string[] addresses = { "AAAAAAAAAAA@gmail.com", "AAAAAAaaaa!@gmail.com" };
            string pattern = @"^.+@[^\.].*\.[a-z]{2,}$";

            foreach (var address in addresses)
            {
                bool response = IsEmail(address, pattern);
                Assert.IsTrue(response);
            }
        }

        public static bool IsEmail(string email,string pattern)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, pattern);
            }
            return false;
        }

        [TestMethod]
        [Description("Another RegEx Example")]
        public void MatchPhone()
        {
            string number = "(555)-555-5555";
            string pattern = @"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$";
            bool response = Regex.IsMatch(number, pattern);
            Assert.IsTrue(response);
        }
    }
}
