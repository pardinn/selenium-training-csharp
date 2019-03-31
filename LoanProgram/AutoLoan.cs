using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    class AutoLoan : Loan
    {
        public AutoLoan(string loanNumber, string loanType, string customerLastName, string customerFirstName, double interestRate,
            decimal loanAmount, double loanYears, int yearBuilt, string model, string make, string color)
            : base(loanNumber, loanType, customerLastName, customerFirstName, interestRate, loanAmount, loanYears)
        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Color = color;
        }

        public int YearBuilt { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / Payments() * LoanPrincipal());
        }

        private decimal LoanPrincipal()
        {
            return LoanAmount + 1000;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n\tMake:\t" + Make +
                "\n\tModel:\t" + Model +
                "\n\tYear Built:\t" + YearBuilt +
                "\n\tColor:\t" + Color +
                "\n\tCalculated Interest:\t" + CalculateInterest().ToString("C");
        }
    }
}
