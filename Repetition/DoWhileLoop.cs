﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition
{
    [TestClass]
    public class DoWhileLoop
    {
        [TestMethod]
        public void Test_Do_While()
        {
            int sum = 0;
            int number = 1;
            do
            {
                sum += number;
                number++;
            } while (number <= 10);

            Assert.AreEqual(55, sum);
        }
    }
}
