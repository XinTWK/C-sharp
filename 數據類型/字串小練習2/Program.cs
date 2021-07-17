using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串小練習2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a string here: ");
            // Read first input string
            string Mystring = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            // Read the character input to seatch
            char searchInput = Console.ReadLine()[0];

            // Gets the Index of the character from the string
            int searchIndex = Mystring.IndexOf(searchInput);
            // Prints the Index as a search result on console
            Console.WriteLine("Index of character {0} in string is {1}",searchInput,searchIndex);

            Console.Write("Enter first name: ");
            // Read the first name
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            // Read the last name
            string lastName = Console.ReadLine();

            // Concatinate the firstName and lastName variable and assign that to fullName variable
            string fullName = string.Concat(firstName, " ", lastName);
            // prints the full name on the console
            Console.WriteLine("Your full name is {0}", fullName);


        }
    }
}
