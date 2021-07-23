using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
// Introduce family members from different fmailies to each other via console

namespace _08_JaggedArray_小練習
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] JoesFamily = new string[] { "Marha", "Robert" };

            string[][] friendsandfamily = new string[][]
            {
                new string[]{"Michael","Sandy"},
                new string[]{"Frank","Claudia"},
                new string[]{"Andrew","Michelle"},
                JoesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsandfamily[0][0], friendsandfamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsandfamily[1][1], friendsandfamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsandfamily[0][1], friendsandfamily[2][1]);
            Console.ReadKey();
        }
    }
}
