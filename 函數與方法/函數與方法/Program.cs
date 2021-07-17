using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函數與方法
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpcific("I am an argument and am Called from a method");
            Console.Read();

        }
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");

        }

        public static void WriteSomethingSpcific(string myText)
        {
            Console.WriteLine(myText);
           
        }

    }
}
