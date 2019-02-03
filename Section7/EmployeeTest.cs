using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section7
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Class_Employee_Default_Name()
        {
            Employee employee = new Employee(1, "Victor", "Moraes", DateTime.Now, "QA", "QA Analyst", 6500.00);
            Assert.AreEqual("Victor Moraes", employee.GetFullName());
        }

        [TestMethod]
        public void Class_Employee_Formal_Name()
        {
            Employee employee = new Employee("Natalia", "Smirnova", "Writer");
            Assert.AreEqual("Smirnova, Natalia", employee.GetFormalName());
        }

        [TestMethod]
        public void Test_Employee_ID_Set()
        {
            Employee employee1 = new Employee(123);

            employee1.JobTitle = "Manager";

            string jobLocation = employee1.JobLocation();
            Assert.AreEqual("Boston", jobLocation);
        }

        [TestMethod]
        public void To_String_Test()
        {
            Employee employee1 = new Employee("Victor", "Moraes", 12345, "QA");
            Console.WriteLine(employee1);
        }
    }
}
