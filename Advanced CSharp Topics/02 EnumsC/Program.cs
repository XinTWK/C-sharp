using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnumsC
{
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Month { January = 1, February, March, April, May, June, July = 12, August, September, October, November, December }

    class Program
    {
        static void Main(string[] args)
        {
            Day friday = Day.Friday;
            Day sunday = Day.Sunday;

            Day a = Day.Friday;

            Console.WriteLine(friday == a);

            Console.WriteLine(Day.Monday);
            Console.WriteLine((int)Day.Monday);

            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.August);

            Console.ReadKey();
        }
    }
}
