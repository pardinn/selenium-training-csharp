using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdvancedOOTopics
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            //Person myPerson = new Person("1234", "Moraes", "Victor", 32);
            //Student myStudent = new Student("1111", "Baker", "Bob", 26, "Computer Science", "9999");

            //string exercise = myStudent.GetExerciseHabits();
        }

        [TestMethod]
        public void Composition_Test()
        {
            DateTime dateOfBirth = new DateTime(1986, 11, 21);
            Student myStudent = new Student("1111", "Baker", "Bob", 26, "Computer Science", "9999", dateOfBirth);
        }

        [TestMethod]
        public void Protected_Test()
        {
            DateTime dateOfBirth = new DateTime(1986, 11, 21);
            Student myStudent = new Student("1111", "Baker", "Bob", 26, "Computer Science", "9999", dateOfBirth);
            Console.WriteLine(myStudent.GetDOB());
        }
    }
}
