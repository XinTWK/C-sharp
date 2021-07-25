using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InheritanceChallenge2
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string compantCar, string name,string firstName,int salary) : base (name,firstName,salary)
        {
            this.CompanyCar = compantCar;
            
        }

        public void Lead()
        {
            Console.WriteLine("I'm boss! My name is {0} {1}",FirstName,Name);
        }
    }
}
