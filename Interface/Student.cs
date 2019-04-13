using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Student : Person, ITraveler
    {
        public Student(string idNumber, string lastName, string firstName, int age, string major, string studentId, DateTime dateOfBirth)
            : base(idNumber, lastName, firstName, age, dateOfBirth)
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
    }
}
