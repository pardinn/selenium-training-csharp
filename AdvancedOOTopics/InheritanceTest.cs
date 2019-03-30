using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

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

        [TestMethod]
        public void Test_Student_As_Person()
        {
            ArrayList personList = new ArrayList();

            DateTime dateOfBirth1 = new DateTime(1986, 11, 21);
            Person myPerson = new Person("1234", "Moraes", "Victor", 32,dateOfBirth1);

            DateTime dateOfBirth2 = new DateTime(1992, 11, 21);
            Student myStudent = new Student("1111", "Baker", "Bob", 26, "Computer Science", "9999", dateOfBirth2);

            personList.Add(myPerson);
            personList.Add(myStudent);

            foreach(Person p in personList)
            {
                Console.WriteLine(p.HoursOfSleep());
            }
        }
    }
}
