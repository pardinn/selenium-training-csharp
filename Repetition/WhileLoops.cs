using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repetition
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1;
            while (number < 11)
            {
                //the code that will continue to execute while the statement
                //conditional is true
                Console.WriteLine(number);
                number++; //number = number + 1
            }

        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;
            Console.WriteLine("post increment value is: {0}", number++);
            Console.WriteLine("pre increment value is: {0}", ++number);
            Console.WriteLine("post decrement value is: {0}", number--);
            Console.WriteLine("pre decrement value is: {0}", --number);
        }

        [TestMethod]
        public void Nested_Loops()
        {
            int number1 = 1;
            int number2 = 1;
            while (number1 <= 5)
            {
                while (number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }
                number1++;
            }
        }

        [TestMethod]
        public void Nested_Loop_Practice()
        {
            int outer = 0;
            while (outer < 3)
            {
                int inner = 10;
                while (inner > 5)
                {
                    Console.WriteLine($"Outer: {outer}\tInner: {inner}");
                    inner--;
                }
                outer++;
            }
        }

        [TestMethod]
        public void DELETE_ME()
        {
            List<int> s = new List<int> { 1, 2, 1, 3, 2, 1, 1, 2, 2, 2, 4, 10, 15, 12, 21, 11};
            int d = 21;
            int m = 11;
            int result = birthday(s,d,m);
            Console.WriteLine(result);
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int total = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                var segsSum = s.GetRange(i, m).Aggregate((a, b) => a + b);
                if (segsSum == d)
                {
                    total++;
                }
            }
            return total;
        }

    }
}
