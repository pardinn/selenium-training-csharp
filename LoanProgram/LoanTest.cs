using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanProgram
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void Test_Auto_Loan()
        {
            AutoLoan autoLoan = new AutoLoan("1234", "Auto Loan", "Moraes", "Victor", .075, 12000, 4, 2015, "Fit", "Honda", "Gray");
            Console.WriteLine(autoLoan);
            decimal interest = autoLoan.CalculateInterest();
            Assert.AreEqual(2925, interest);
        }

        [TestMethod]
        public void Test_Home_Loan()
        {
            HomeLoan homeLoan = new HomeLoan("9999", "Home Loan", "Moraes", "Victor", .035, 210000, 30, "Damaged St, 5", 2000, 75.00);
            Console.WriteLine(homeLoan);
            Assert.AreEqual(3010, homeLoan.CalculateInterest());
        }
    }
}
