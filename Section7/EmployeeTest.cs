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
            Employee employee = new Employee("Natalia", "Smirnova");
            Assert.AreEqual("Smirnova, Natalia", employee.GetFormalName());
        }
    }
}
