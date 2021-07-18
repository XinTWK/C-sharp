using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lengthOfText += currentLenght;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough! "+wholeText);
            Console.Read();
        }
    }
}
