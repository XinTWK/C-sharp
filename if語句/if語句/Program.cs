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
            string temperature =Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            if(numTemp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine");
            }
            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        
        }
    }
}
