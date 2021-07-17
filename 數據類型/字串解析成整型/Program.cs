using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串解析成整型
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            string result = myString + mySecondString; // 1513
            Console.WriteLine(result);

            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2; // 28

            Console.WriteLine(resultInt);

            Console.Read();
        }
    }
}
