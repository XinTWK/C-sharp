using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 嵌套的if語句
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();

            if(isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if(userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, admin");
                    }
                }
            }

            Console.Read();
        }
    }
}
