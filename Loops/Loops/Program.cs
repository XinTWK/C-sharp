using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int counter = 0; counter < 50; counter+=5)
            //{
            //    Console.WriteLine(counter + " is lower than 50");
            //}
            //Console.WriteLine("For loop is done");

            // 小挑戰 寫一個只輸出0~20的奇數
            for (int i = 1; i<20;i+=2)
            {
                Console.WriteLine(i);
            }
            
            Console.Read();
        }
    }
}
