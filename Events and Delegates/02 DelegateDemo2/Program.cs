using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DelegateDemo2
{
    class Program
    {            
        // defining a delegate type called FilterDelegate that takes a person object and returns a bool
        public delegate bool FilterDelegate(Person p);


        static void Main(string[] args)
        {
            // Create 4 Person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41};
            Person p2 = new Person() { Name = "Sif", Age = 69};
            Person p3 = new Person() { Name = "Walter", Age = 12};
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the object to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            // don't forget the ; at the end because we are declaring a variable and assinging it's value at the same time
            // just like int = 3; for example
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Between 20 and 30: ", people,filter);

            DisplayPeople("All: ", people, delegate (Person p) 
            {
                return true;
            });

            // statement lambda
            // a search keyword to filter the names
            string searchKeyword = "A";
            DisplayPeople("age > 20 with seatch keyword: " + searchKeyword, people, (p) =>
             {
                 if (p.Name.Contains(searchKeyword) && p.Age > 20)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             });

            // expression lambda
            // here we are using expression lambda (one line of code)
            DisplayPeople("excatly 25: ", people, p => p.Age == 25);


        }

        // a method to display the list of people the filter condition (returns true)
        // this method will take a title to be displayed, the list of people and a filter delegate
        static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
        {
            // print the title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // check if this person passes the filter
                if (filter(p))
                {
                    // print the person's name and age
                    Console.WriteLine("{0}, {1} years old",p.Name,p.Age);
                }
            }
        }

        // ==================== FILTERS ====================

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

    }
}
