using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTest
{
    [TestClass]
    public class ClassLibraryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibraryProject.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);
        }
    }
}
