using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    class HomeLoan : Loan
    {
        public HomeLoan(string loanNumber, string loanType, string customerLastName, string customerFirstName, double interestRate,
            decimal loanAmount, double loanYears, string address, int yearBuilt, double squareFootage)
            : base(loanNumber, loanType, customerLastName, customerFirstName, interestRate, loanAmount, loanYears)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public double SquareFootage { get; set; }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / Payments() * LoanPrincipal());
        }

        private decimal LoanPrincipal()
        {
            return LoanAmount + 5000;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n\tAddress:\t" + Address +
                "\n\tYear Built:\t" + YearBuilt +
                "\n\tSq. Footage:\t" + SquareFootage +
                "\n\tCalculated Interest:\t" + CalculateInterest().ToString("C");
        }
    }
}
