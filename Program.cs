using System;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company();
            myCompany.Name = "Not Fortnite";

            // Create three employees
            List<Employee> myEmployees = new List<Employee>
              {
                new Employee {Name = "AP", Position = "The GameMaker", DateStarted = "1/13/2023"},
                new Employee {Name = "RP", Position = "The Muscle", DateStarted = "4/5/2023"},
                new Employee {Name = "KP", Position = "The Boss", DateStarted = "7/28/2023"},
              };

            // Assign the employees to the company
            foreach (var employee in myEmployees)
            {
                Console.WriteLine($"{employee.Name} has worked for {myCompany.Name} as {employee.Position} since {employee.DateStarted}");
            }

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
    }

    class Company
    {
        public String Name { get; set; } = string.Empty;

    }

    class Employee
    {
        public String Name { get; set; } = string.Empty;
        public String Position { get; set; } = string.Empty;
        public String DateStarted { get; set; } = string.Empty;
    }
