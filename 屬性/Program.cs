using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 屬性
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            //Box box = new Box();
            //box.length = 3;
            //box.SetLength(4);
            //box.height = 4;
            //box.Height = -4;
            //box.Width = 5;
            Console.WriteLine("Box Width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box Width is " + box.Width);

            Console.WriteLine("Box volume is " + box.Volume);
            box.DisplayInfo();

            Console.WriteLine("Front surface of the box is {0}" , box.FrontSurface);
            Console.Read();
        }

    }
}
