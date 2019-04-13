using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;
        protected DateTime dateOfBirth;

        public Person(string idNumber, string lastName, string firstName, int age, DateTime dateOfBirth)
        {
            this.idNumber = idNumber;
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
