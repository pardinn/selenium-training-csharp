using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Person
    {
        public Person(string idNumber, string lastName, string firstName)
        {
            IdNumber = idNumber;
            LastName = lastName;
            FirstName = firstName;
        }

        public string IdNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return "First Name: " + FirstName + "\n" +
                "Last Name: " + LastName;
        }
    }
}
