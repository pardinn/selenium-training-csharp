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
        long employeeID;
        string firstName;
        string lastName;
        DateTime dateOfHire;
        string department;
        string jobTitle;
        double monthlySalary;

        // constructors
        public Employee(int empID)
        {
            EmployeeID = empID;
        }

        public Employee(string empFirstName, string empLastName, string title)
        {
            FirstName = empFirstName;
            LastName = empLastName;
            JobTitle = title;
        }

        public Employee(long empID, string empFirstName, string empLastName, DateTime hireDate, string dept, string title, double salary)
        {
            EmployeeID = empID;
            FirstName = empFirstName;
            LastName = empLastName;
            DateOfHire = hireDate;
            JobTitle = title;
            MonthlySalary = salary;
        }

        public Employee(string empFirstName, string empLastName, long empId, string title)
        {
            FirstName = empFirstName;
            LastName = empLastName;
            EmployeeID = empId;
            JobTitle = title;
        }

        //properties
        public long EmployeeID { get; set; }
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
        public string JobTitle { get; set; }
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

        public string JobLocation()
        {
            if(JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";
            }

            return "New York";
        }

        public override string ToString()
        {
            return EmployeeID + ": " + GetFullName() + " Job Title: " + JobTitle;
        }
    }


}
