using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Student : Person, ITraveler
    {
        public Student(string idNumber, string lastName, string firstName, string major, string studentId)
            : base(idNumber, lastName, firstName)
        {
            Major = major;
            StudentId = studentId;
        }

        public string Major { get; set; }
        public string StudentId { get; set; }


        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";
        }
        public double DetermineMiles()
        {
            return 75.0;
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
