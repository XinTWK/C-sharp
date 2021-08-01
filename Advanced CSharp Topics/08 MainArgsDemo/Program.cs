using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MainArgsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // the args array cannot be null. So, it's safe to access the Length property without null checking
            // so we check the length of the array if it's zero it means no argument were provided to the application
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ,Please provide arguments next time. Pass Help if you want to get more details.");
                // pause the application so it does't quite after printing our error message
                Console.ReadKey();
                // quit the application entirly since we can't proceed further since, the arguments are empty
                return;
            }

            // check if the first command we got is help
            if (args[0] == "help")
            {
                // display manual
                Console.WriteLine("********************** Instructions:");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers");
                Console.WriteLine("*********************");

                // pause
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();

        }
    }
}
