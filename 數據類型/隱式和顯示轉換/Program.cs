using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隱式和顯示轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            // 隱式轉換
            int num = 210124;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;



            double myDouble = 13.37;
            int myint;
            // 顯示轉換
            // cast double to int;
            myint = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
