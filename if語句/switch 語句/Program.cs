using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_語句
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年齡: ");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 15:
                    Console.WriteLine("對派對來說太年輕了!");
                    break;
                case 25:
                    Console.WriteLine("趕緊去派對吧!");
                    break;
                default:
                    Console.WriteLine("您幾歲呢?");
                    break;
            }

            if(age == 15)
            {
                Console.WriteLine("對派對來說太年輕了!");
            }
            else if(age == 25)
            {
                Console.WriteLine("趕緊去派對吧!");
            }
            else
            {
                Console.WriteLine("您幾歲呢?");

            }

            string username = "Frank";
            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknow");
                    break;
            }


            Console.Read();

        }

    }
}
