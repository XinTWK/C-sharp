using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("請輸入ENTER增加數量,若要停止增加輸入任意健再按ENTER即可");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("正確人數為: {0}",counter);
            }
            Console.WriteLine("{0} 人在公車裡,按下ENTER結束程式",counter);
            Console.Read();
        }
    }
}
