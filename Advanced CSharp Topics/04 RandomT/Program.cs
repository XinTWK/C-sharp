using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_RandomT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random dice = new Random();
            //int numEyes;

            //for(int i = 0; i < 10; i++)
            //{
            //    numEyes = dice.Next(1,7);
            //    Console.WriteLine(numEyes);
            //}

            Random yesNoMaybe = new Random();
            Console.WriteLine("Please enter your question");
            Console.ReadLine();

            int answerNum;
            answerNum = yesNoMaybe.Next(1, 4);
            
            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            }else if (answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }


            Console.ReadKey();
        }
    }
}
