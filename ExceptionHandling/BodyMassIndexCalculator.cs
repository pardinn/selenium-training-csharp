using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class BodyMassIndexCalculator
    {
        public BodyMassIndexCalculator(int lbs, int feet, int inches)
        {
            Weight = lbs;
            HeightInFeet = feet;
            HeightInInches = inches;
        }

        public int Weight { get; set; }
        public int HeightInFeet { get; set; }
        public int HeightInInches { get; set; }

        public double CalculateBMI()
        {
            return (Weight * 703) / Math.Pow((HeightInFeet * 12 + HeightInInches), 2);
        }

        public override string ToString()
        {
            return "BMI: " + CalculateBMI().ToString("F2");
        }
    }
}
