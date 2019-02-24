using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods
{
    [TestClass]
    public class CodingQuiz
    {
        [TestMethod]
        public void Square_Root_Test()
        {
            Assert.AreEqual(4, MathFunctions.SquareRoot(16), 1);
        }

        [TestMethod]
        public void Sum_Int_Test()
        {
            Assert.AreEqual(4, MathFunctions.Sum(2, 2));
        }

        [TestMethod]
        public void Sum_Double_Test()
        {
            Assert.AreEqual(5, MathFunctions.Sum(2.5, 2.5));
        }

        [TestMethod]
        public void Sum_Decimal_Test()
        {
            Assert.AreEqual(5M, MathFunctions.Sum(2.5M, 2.5M));
        }
    }
}
