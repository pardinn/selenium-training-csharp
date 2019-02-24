using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods
{
    [TestClass]
    public class OptionalAndNamedParameters
    {
        [TestMethod]
        public void Test_Named_Parameters()
        {
            int sum11 = MathFunctions.Sum(5, 6);

            int sum12 = MathFunctions.Sum(number1: 6, number2: 6);

            int num = 5;
            int sum13 = MathFunctions.Sum(num, number2: 8);
        }

        [TestMethod]
        public void Test_Optional_Parameters()
        {
            int sum10 = MathFunctions.Sum(0);
            int sum12 = MathFunctions.Sum(2);
            int sum15 = MathFunctions.Sum();
            int sum13 = MathFunctions.Sum(number2: 6);
        }
    }
}
