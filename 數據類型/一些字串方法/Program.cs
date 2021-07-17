using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一些字串方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Denis";
            string lastName = "Panjuta";
            string fullName = string.Concat("", firstName, lastName, "");
            Console.WriteLine(firstName.Substring(2)); // 輸出:"nis"
            Console.WriteLine(firstName.ToLower()); // 輸出:"denis"
            Console.WriteLine(firstName.ToUpper()); // 輸出:"DENIS"
            Console.WriteLine(fullName.Trim()); // 輸出:DenisPanjuta" 修剪到頭尾的空格
            Console.WriteLine(firstName.IndexOf('e')); // 輸出:1




            Console.Read();
        }
    }
}
