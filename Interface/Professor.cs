using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Professor : Person, ITraveler
    {
        public Professor(string idNumber, string lastName, string firstName, int age, string empId, string subject, DateTime dateOfBirth)
            : base(idNumber, lastName, firstName, age, dateOfBirth)
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
    }
}
