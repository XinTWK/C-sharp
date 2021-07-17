using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串小練習3
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte myByte = 25; // 0 ~ 255
            Console.WriteLine(myByte);

            sbyte mySbyte = -15; // -128 ~ 127
            Console.WriteLine(mySbyte);

            int Myint = -381939; // -2,147,483,648 ~ 2,147,483,647
            Console.WriteLine(Myint);

            uint MyUint = 13145; // 0 ~ 4,294,967,295
            Console.WriteLine(MyUint);

            short MyShort = -32768; // -32,768 ~ 32,767
            Console.WriteLine(MyShort);

            ushort MyUShort = 65535; // 0 ~ 65,535
            Console.WriteLine(MyUShort);

            float Myfloat = -41.4124f; // ±1.5 x 10−45 ~ ±3.4 x 1038
            Console.WriteLine(Myfloat);

            double Mydouble = 231.412345; // ±5.0 × 10−324 ~ ±1.7 × 10308	
            Console.WriteLine(Mydouble);

            char myChar = 'A';
            Console.WriteLine(myChar);

            bool myBool = true;
            Console.WriteLine(myBool);

            string MyText = "I control text";
            Console.WriteLine("MyText = {0}", MyText);

            string numText = "131234";
            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);

            Console.ReadLine();

        }
    }
}
