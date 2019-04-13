using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Professor : Person, ITraveler
    {
        public Professor(string idNumber, string lastName, string firstName, string subject, string empId)
            : base(idNumber, lastName, firstName)
        {
            EmployeeID = empId;
            SubjectArea = subject;
        }

        public string EmployeeID { get; private set; }
        public string SubjectArea { get; private set; }


        public string GetDestination()
        {
            return "The Beach";
        }

        public string GetStartLocation()
        {
            return "Home";
        }
        public double DetermineMiles()
        {
            return 200.00;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n  Destination: " + GetDestination() +
                "\n  Start Location: " + GetStartLocation() +
                "\n  Miles: " + DetermineMiles();
        }
    }
}
