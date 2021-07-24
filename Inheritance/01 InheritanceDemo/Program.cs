using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // method of parent class
            myTV.SwitchOn();
            // method of child class
            myTV.WatchTV();


            Console.ReadKey();
        }
    }
}
