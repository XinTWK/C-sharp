using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 有返回值和參數的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" (1 + 2) + (3 + 4) = " + Add(Add(1, 2), Add(3, 4)));

            //int result = Add(15, 31);
            //Console.WriteLine(result);
            Console.WriteLine("15 + 31 = " + Add(15,31));

            Console.WriteLine("25 * 25 = " + Multiply(25, 25));

            Console.WriteLine("25 / 13 = " + Divide(25, 13));

            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1 , int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1 ,double num2 )
        {
            return num1 / num2;
        }
    }
}
