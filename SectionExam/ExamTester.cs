using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SectionExam
{
    [TestClass]
    public class ExamTester
    {
        /*
         * Create a try/catch block in each test that calls the method and catches the
         * specific exception that is produced. Each method should be handled so that if an
         * exception occurs, the test will still pass.
        */
        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\n\nError in loop termination condition.");
                Console.WriteLine("\nException Type:\t" + ex.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nError in parameter types.");
                Console.WriteLine("\nException type:\t" + ex.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("\nArithmeticException thrown");
                Console.WriteLine("\nException Type:\t" + ex.Message+"\n\n\n");
            }
        }
    }
}
