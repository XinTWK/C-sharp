using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a main class with the Main Method, then a base class Employee with the properties Name, 
//    FirstName, Salary, and the methods Work() and Pause().
// Create a deriving class boss with the property CompanyCar and the method Lead().  
// Create another deriving class of employees - trainees with the properties WorkingHours 
//    and SchoolHours and a method Learn().
// Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
// Don’t forget to create constructors.
// Create an object of each of the three classes(with arbitrary values)
// and call the methods, Lead() of Boss and Work() of Trainee.
// Just print out the respective text, what the respective employees do.
// E.g.Lead() should print out something like. I'm leading. It is up to you what you print out.

namespace _04_InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael","Miller",40000);

            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari","Norris","Chuck",999999999);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32,8,"Garther","Michelle",10000);
            michelle.Leran();
            michelle.Work();

            Console.ReadKey();

        }
    }
}
