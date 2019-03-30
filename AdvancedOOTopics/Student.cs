using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Student : Person
    {
        private string major;
        private string studentId;

        public Student(string idNumber, string lastName, string firstName, int age, string major, string studentId, DateTime dateOfBirth)
            : base(idNumber, lastName, firstName, age, dateOfBirth)
        {
            this.major = major;
            this.studentId = studentId;
        }

        //public override string GetExerciseHabits()
        //{
        //    return "Zero time to exercise";
        //}

        public DateTime GetDOB()
        {
            return base.dateOfBirth;  
        }

        public override string HoursOfSleep()
        {
            return "A student has 6 hours of sleep";
        }
    }
}
