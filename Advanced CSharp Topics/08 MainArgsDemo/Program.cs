﻿using System;
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

            // check the length of args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            // In C# 6 and earlier, you must declare a variable in a separate statement before you pass it as an out argument
            // since if the parsing operation fails the variable passed as out will have it's default value if it was a value
            // if it was a value type, or null if it's a reference type
            // it is more logical to declare and pass the variable in the same line
            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // pause
                Console.ReadKey();
                // quite the app
                return;
            }

            // a variable to store the results
            float result;

            switch(args[0])
            {
                // case 1 'add' add the two numbers and print the value
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}");
                    break;

                // case 2 'sub' sub the two numbers and print the valuer
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sub of {num1} and {num2} is {result}");
                    break;

                // default case, here we handle wrong commands by printing an error message
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;
            }

            Console.ReadKey();

        }
    }
}
