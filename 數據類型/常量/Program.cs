using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    // Constants are immutable values which are known 
    // at compile time and do not change for the life of the program.
    // 常量是不可變的值,他們在編譯時已知並且在程序的生命週期內不會改變
    

    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, month = 12;
        const int days = 365;
        // create a constant of type string with your birthday as its value
        const string birthday = "15.05";

        static void Main(string[] args)
        {
            //days = 366; 不可改值

            Console.WriteLine("My birthday is always going to be : {0}", birthday);
            Console.Read();
        }
    }
}
