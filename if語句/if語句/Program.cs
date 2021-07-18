using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if語句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like? ");
            string temperature =Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if (userEnteredANumber)
            {
                numTemp = number;
                if (numTemp < 20)
                {
                    Console.WriteLine("Take the coat");
                }
                else if (numTemp == 20)
                {
                    Console.WriteLine("Pants and Pull over should be fine");
                }
                else if (numTemp > 30)
                {
                    Console.WriteLine("It's super hot! ");
                }
                else
                {
                    Console.WriteLine("Shorts are enough today");
                }
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set at temperature");
            }


           

            Console.Read();
        
        }
    }
}
