using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            //given the temperature in fahrenheit 
            double tempInF = 55;

            //use a math expression to convert the temperature to celsius
            double tempInC = (tempInF - 32) * 5 / 9;

            //display a output string to the console that says
            //The temp in F {given temp} is {temp} in C
            //replacing the values as necessary in the string
            Console.WriteLine($"The temp {tempInF} in F is {tempInC} in C");
            Assert.AreEqual(12.77,tempInC,0.01);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            //given the temperature in celsius
            double tempInC = 32;

            //use a math expression to convert the temperature to fahrenheit
            double tempInF = (tempInC * 9 / 5) + 32;

            //display a output string to the console that says
            //The temp in C {given temp} is {temp} in F
            //replacing the values as necessary in the string
            Console.WriteLine($"The temp {tempInC} in C is {tempInF} in F");
            Assert.AreEqual(89.6,tempInF,0.001);
        }
    }
}
