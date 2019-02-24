using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods
{
    [TestClass]
    public class EndOfSectionExam
    {
        [TestMethod]
        public void Test_Calculate_Taxable_Value()
        {
            PropertyTaxCalculation property = new PropertyTaxCalculation("21B Baker Street", 150000M);
            Assert.AreEqual(129050M, property.GetTaxableValue());
        }

        [TestMethod]
        public void Test_Current_Year_Assessed_Value()
        {
            PropertyTaxCalculation property = new PropertyTaxCalculation("21B Baker Street", 150000M);
            Assert.AreEqual(154050M, property.GetCurrentYearAssessedValue());
        }

        [TestMethod]
        public void Property_Tax_Calculation()
        {
            PropertyTaxCalculation property1 = new PropertyTaxCalculation("21B Baker Street", 110000M);
            Console.WriteLine(property1);
            PropertyTaxCalculation property2 = new PropertyTaxCalculation("123 New Street", 150000M);
            Console.WriteLine(property2);
            PropertyTaxCalculation property3 = new PropertyTaxCalculation("W 1600 Street", 190000M);
            Console.WriteLine(property3);

        }
    }
}
