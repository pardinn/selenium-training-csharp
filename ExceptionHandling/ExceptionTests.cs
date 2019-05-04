using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionHandling
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;

            if (totalScores != 0 && countOfScores != 0)
            {
                double average = totalScores / countOfScores;
            }
        }

        [TestMethod]
        public void Test_Division()
        {
            ExceptionHelper.DivisionTest();
        }

        [TestMethod]
        public void Test_StateCheck()
        {
            try
            {
                ExceptionHelper.CheckStateOk("MA");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
