﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interface
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void Test_Traveler()
        {
            Professor prof1 = new Professor("1111", "Sara", "Burke", "Math", "00234");
            Professor prof2 = new Professor("1112", "John", "Duncan", "Science", "000567");
            Student stu1 = new Student("0001", "James", "Ray", "Computer Science", "0222");
            Student stu2 = new Student("0002", "Clare", "Edwards", "Math", "0244");

            Person[] listOfPeople = new Person[4];
            listOfPeople[0] = prof1;
            listOfPeople[1] = prof2;
            listOfPeople[2] = stu1;
            listOfPeople[3] = stu2;

            foreach (Person someone in listOfPeople)
            {
                Console.WriteLine(someone);
            }
        }
    }
}
