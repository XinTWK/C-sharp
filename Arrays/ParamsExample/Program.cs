using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price is {0}, PI is {1}, at is {2}", 32, 3.14, '@');
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}={8}", 1, 2, 3, 4, 5, 6, 7, 8, 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8);
        }
    }
}
