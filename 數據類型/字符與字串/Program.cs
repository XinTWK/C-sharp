using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符與字串
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Justin";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCapsMessage = message.ToLower();

            //Console.WriteLine("My name is " + myname);
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCapsMessage);

            Console.ReadKey();
        }
    }
}
