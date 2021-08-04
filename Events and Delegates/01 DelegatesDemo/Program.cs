
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----before----");
            // print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // calling RemoveAll and passing a method Filter we created.
            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            // print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // a method called Filter that takes a string
        static bool Filter(string s)
        {
            // return whether the string a contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }


    }
}
