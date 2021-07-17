using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operator 一元運算符
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}",!isSunny);

            // increment operators 增值運算符
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator 減值運算符
            num = 0;
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", num);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result); // 5 + 3 = 8
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result); // 5 - 3 = 2
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result); // 5 * 3 = 15 
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result); // 5 / 3 = 1 (int)
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result); // 5 % 3 = 2 (取餘數)

            // relational and type operators 關係運算符 與 類型運算符
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}",isLower); // 5 < 3 false

            // equality operator
            bool isEqual;
            isEqual = num1 == num2; 
            Console.WriteLine("result of num1 == num2 is {0}", isEqual); // 5 == 3 false

            isEqual = num1 != num2; // not equal
            Console.WriteLine("result of num1 != num2 is {0}", isEqual); // 5 != 3 true

            // conditional operators 條件運算符
            bool isLowerAndSunny;
            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny); // F && T = F

            bool isLowerOrSunny;
            // condition1 OR condition2
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerOrSunny); // F || T = T



            Console.ReadKey();
        }
    }
}
