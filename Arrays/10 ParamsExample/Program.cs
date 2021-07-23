using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');

            //Console.WriteLine("Price is {0}, PI is {1}, at is {2}", 32, 3.14, '@');
            //Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}={8}", 1, 2, 3, 4, 5, 6, 7, 8, 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8);

            ParamsMethod(); // 輸出空的 程式也不會出錯

            //ParamsMethod("This", " is ", " a ", " long ", " string ", " I ", " have ", " no ", " idea ", " when ", " it's ", " going ", " to ", " end ", "....."); // I can keep going

            Console.ReadKey();

        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]);
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // foreach loop to go through the array of objects
            foreach (object obj in stuff)
            {
                // print each object followed by a space
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
