using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InheritanceChallenge2
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name,string firstName,int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            Name = "Justin";
            FirstName = "Lee";
            Salary = 50000;

        }

        public void Work()
        {
            Console.WriteLine("I'm workint");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
