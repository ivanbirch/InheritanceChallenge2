using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string lastName, string firstName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            LastName = "Birch";
            FirstName = "Ivan";
            Salary = 12345;
        }
        public void Work()
        {
            Console.WriteLine("I am working");
        }

        public void Pause()
        {
            Console.WriteLine("I am taking a break");
        }
    }
}
