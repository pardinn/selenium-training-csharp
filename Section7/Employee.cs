using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    class Employee
    {
        // private variables internal for the classes
        long employeeNumber;
        string firstName;
        string lastName;
        DateTime dateOfHire;
        string department;
        string jobDescription;
        double monthlySalary;

        // constructors
        public Employee(string empFirstName, string empLastName)
        {
            FirstName = empFirstName;
            LastName = empLastName;
        }

        public Employee(long empNo, string empFirstName, string empLastName, DateTime hireDate, string dept, string job, double salary)
        {
            EmployeeNumber = empNo;
            FirstName = empFirstName;
            LastName = empLastName;
            DateOfHire = hireDate;
            JobDescription = job;
            MonthlySalary = salary;
        }

        //properties
        public long EmployeeNumber { get; set; }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 0)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name not informed");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Surname not informed");
                }
            }
        }

        public DateTime DateOfHire { get; set; }
        public string Department { get; set; }
        public string JobDescription { get; set; }
        public double MonthlySalary { get; set; }

        // methods  
        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public string GetFormalName()
        {
            return $"{LastName}, {FirstName}";
        }
    }


}
