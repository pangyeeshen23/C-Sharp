using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }


        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name : {this.Name}, Age : {this.Age}");
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string name, int age, string address, string jobTitle, int employeeID) : base(name, age, address)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (derived class) constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            base.DisplayPersonInfo();
            Console.WriteLine($"Job Title : {this.JobTitle}, Employee Id : {this.EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string address, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, address, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
