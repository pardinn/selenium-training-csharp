using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class PropertyTaxCalculation
    {
        private readonly decimal millage_rate = 10.03M;
        private readonly decimal assessment_increase = 0.027M;
        private readonly decimal exemption = 25000M;
        string PropertyAddress { get; set; }
        decimal LastYearValue { get; set; } 

        public PropertyTaxCalculation(string address, decimal lastYearVal)
        {
            PropertyAddress = address;
            LastYearValue = lastYearVal;
        }

        public decimal GetCurrentYearAssessedValue()
        {
            return LastYearValue * (1 + assessment_increase);
        }

        public decimal GetTaxableValue()
        {
            return GetCurrentYearAssessedValue() - exemption;
        }

        public decimal GetTaxesDue()
        {
            return GetTaxableValue() / 1000 * millage_rate;
        }

        public override string ToString()
        {
            return string.Format(
                "Property Address: {0}\n" +
                "Last Year Assessed Value: {1:C}\n" +
                "Current Year Assessed Value: {2:C}\n" +
                "Exemption: {3:C}\n" +
                "Taxable Value: {4:C}\n" +
                "Milleage Rate (per $1000): {5:C}\n" +
                "Taxes Due: {6:C}\n", PropertyAddress, LastYearValue, GetCurrentYearAssessedValue(), 
                exemption, GetTaxableValue(), millage_rate, GetTaxesDue());
        }

    }
}
