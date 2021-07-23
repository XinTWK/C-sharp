using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ParamsExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, -13, 1, 50); // here we passed 7 values

            Console.WriteLine("The minimum is : {0}", min);


            Console.ReadKey();
        }


        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue; // 把 min 設為 int的最大值

            foreach (int numner in numbers)
            {
                if (numner < min)
                    min = numner;
            }
            return min;
        }
    }
}
