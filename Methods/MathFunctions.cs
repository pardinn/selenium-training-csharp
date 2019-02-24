using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MathFunctions
    {
        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        internal static void NumbersOut(out int value)
        {
            value = 9;
        }

        internal static void NumbersRef(ref int value)
        {
            value = 7;
        }

        public static int Sum(int number1 = 5, int number2 = 10)
        {
            return number1 + number2;
        }


        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static decimal Sum(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

    }
}
