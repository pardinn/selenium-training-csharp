using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Person
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

        //public abstract string GetExerciseHabits();

        public virtual string HoursOfSleep()
        {
            return "A person has 8 hours of sleep";
        }
    }
}
