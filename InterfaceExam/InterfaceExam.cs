using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceExam
{
    [TestClass]
    public class InterfaceExam
    {
        //In this exam, you must take the 2 tests below pass without changing a 
        //single line of code in the tests.
        //You basically need to fix all of the compilation errors and make the tests pass,
        //without touching the tets.
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual("Page Name 1", pageObject1.PageName);
        }

        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual("Page Name 2", pageObject2.PageName);
        }
    }
}
