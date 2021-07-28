using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileIOC
{
    class Program
    {
        // Exanple 1 - reading Text
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"D:\C#\FileIO\01 FileIOC\textFile.txt");
            Console.WriteLine("TextFile contaions following text: \n{0}",text);

            string[] lines = System.IO.File.ReadAllLines(@"D:\C#\FileIO\01 FileIOC\textFile.txt");
            Console.WriteLine("Contents of textfile.txt = ");


            Console.ReadKey();
        }
    }
}
