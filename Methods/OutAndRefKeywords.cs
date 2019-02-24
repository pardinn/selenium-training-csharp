using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods
{
    [TestClass]
    public class OutAndRefKeywords
    {
        [TestMethod]
        public void Test_Out_Parameter()
        {
            int number1;
            MathFunctions.NumbersOut(out number1);
            Assert.AreEqual(9, number1);
        }

        [TestMethod]
        public void Test_Ref_Parameter()
        {
            int number1 = 0;
            MathFunctions.NumbersRef(ref number1);
            Assert.AreEqual(7, number1);
        }
    }
}
