using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數據類型
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;
            // declaring multiple variables at once
            int num3, num4, num5;

            // assign a value to a variavle
            num1 = 13;


            // declaring and initializing a variable in one go
            int num2 = 23;
            long myLongNum = 194123879851123424;
            num2 = 100;
            // using concatination
            Console.WriteLine("num1 is " + num1);

            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            //int dIDivInt = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);

            Console.Read();
        }
    }
}
