using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Imagine you are a developer and get a job in which you need to create a program for a teacher.He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum.Finally once he is done entering scores, the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
Test your program thoroughly.
*/

namespace loop_小挑戰
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0, total = 0, lastNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("最後一個數字為 {0}", lastNumber);
                Console.WriteLine("請輸入下一個分數");
                Console.WriteLine("當前數量為: {0}", count);
                Console.WriteLine("請輸入 \"-1\" 來開始計算平均分數");
                Console.WriteLine("-----------------------------");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-----------------------------");
                    // 計算平均分數
                    double average = (double)total / (double)count;
                    Console.WriteLine("平均分數為:  {0}", average);
                }
                if (int.TryParse(input, out lastNumber) && lastNumber > 0 && lastNumber < 21)
                {
                    total += lastNumber;
                    
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {

                        Console.WriteLine("請輸入1~20之間的數字!!");
                        Console.WriteLine("-----------------------------");

                    }
                    continue;
                }
                count++;
            }

            Console.Read();
        }
    }
}
