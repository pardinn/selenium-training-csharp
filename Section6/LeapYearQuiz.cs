using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class LeapYearQuiz
    {
        [TestMethod]
        public void Leap_Year_Test_2018()
        {
            string result = IsLeapYear(2018);
            Assert.AreEqual("No", result);
        }
        [TestMethod]
        public void Leap_Year_Test_2020()
        {
            string result = IsLeapYear(2020);
            Assert.AreEqual("Yes", result);
        }

        public string IsLeapYear(int givenYear)
        {
            int nYear;
            int nFhun;
            int nHun;
            int nFour;
            int nEven;
            string sFhun = "No";
            string sHun = "No";
            string sFour = "No";

            //what year are we testing
            nYear = givenYear;

            //checks to see if year leaves a remainder  to determine if leap year
            nFhun = nYear % 400;
            nHun = nYear % 100;
            nFour = nYear % 4;
            nEven = nYear % 2;
            sFhun = "Divisible by 400: " + YesOrNo(nFhun == 0);
            sHun = "Divisible by 100: " + YesOrNo(nHun == 0);
            sFour = "Divisible by 4: " + YesOrNo(nFour == 0);

            //display all operations
            Console.WriteLine("Year: " + nYear);
            Console.WriteLine(sFour);
            Console.WriteLine(sHun);
            Console.WriteLine(sFhun);

            //determine if leap year
            if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun == 0) && (nFhun != 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if ((nEven == 0) && (nFour == 0) && (nHun != 0) && (nFhun == 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if (nEven == 1)
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
        }

        public string YesOrNo(bool flag)
        {
            if (flag)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
