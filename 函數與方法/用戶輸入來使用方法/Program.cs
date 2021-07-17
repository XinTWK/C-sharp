using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用戶輸入來使用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("總和為: " + Calculate());

            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("請輸入第一組數字: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("第一組數字為: " + input1);

            Console.WriteLine("請輸入第二組數字: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("第二組數字為: " + input2);

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int result = num1 + num2;



            return result;

        }

    }
}
