using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Challenge - Methods
In this challenge you will deepen your understanding for methods.
Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

Greet all your three friends.
*/


namespace 方法小練習
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyFriend1 = "張三";
            string MyFriend2 = "李四";
            string MyFriend3 = "王五";

            //GreetFriend(MyFriend1);
            //GreetFriend(MyFriend2);
            //GreetFriend(MyFriend3);

            GreetFriend(MyFriend1, MyFriend2, MyFriend3);


            Console.Read();

        }

        //public static void GreetFriend(string friendName)
        //{
        //    Console.WriteLine("Hi " + friendName + " , my friend");
        //}


        public static void GreetFriend(string friendName1, string friendName2,string friendName3)
        {
            Console.WriteLine("Hi " + friendName1 + " , my friend");
            Console.WriteLine("Hi " + friendName2 + " , my friend");
            Console.WriteLine("Hi " + friendName3 + " , my friend");


        }
    }
}
