using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    abstract class Loan
    {
        public Loan(string loanNumber, string loanType, string customerLastName, string customerFirstName, double interestRate, decimal loanAmount, double loanYears)
        {
            LoanNumber = loanNumber;
            LoanType = loanType;
            CustomerLastName = customerLastName;
            CustomerFirstName = customerFirstName;
            InterestRate = interestRate;
            LoanAmount = loanAmount;
            LoanYears = loanYears;
        }

        public string LoanNumber { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public double InterestRate { get; set; }
        public decimal LoanAmount { get; set; }
        public double LoanYears { get; set; }
        public string LoanType { get; set; }

        public abstract decimal CalculateInterest();

        public decimal Payments()
        {
            return Convert.ToDecimal(LoanYears) / 12M;
        }

        public override string ToString()
        {
            return LoanType.ToUpper() + " Number:\t" + LoanNumber +
                "\n\tCustomer Name:\t" + CustomerLastName + ", " + CustomerFirstName +
                "\n\tLoan Amount:\t" + LoanAmount.ToString("C") +
                "\n\tInterest Rate:\t" + InterestRate.ToString("p2") +
                "\n\tLoan Duration:\t" + LoanYears;
        }
    }
}
