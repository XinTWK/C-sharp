using System;
using System.Text;
using System.IO;

namespace _01_FileIOC
{
    class Program
    {

        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"D:\C#\FileIO\01 FileIOC\highscores.txt", lines);

            //// Method 2
            //Console.WriteLine("Please give the file a name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please enter the text for the file");
            //string input = Console.ReadLine();
            //File.WriteAllText(@"D:\C#\FileIO\01 FileIOC\" + fileName + ".txt", input);

            // Method 3
            using (StreamWriter file = new StreamWriter(@"D:\C#\FileIO\01 FileIOC\myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"D:\C#\FileIO\01 FileIOC\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

            // Exanple 1 - reading Text
            //string text = System.IO.File.ReadAllText(@"D:\C#\FileIO\01 FileIOC\textFile.txt");
            //Console.WriteLine("TextFile contaions following text: {0}", text);

            //string[] lines = System.IO.File.ReadAllLines(@"D:\C#\FileIO\01 FileIOC\textFile.txt");
            //Console.WriteLine("Contents of textfile.txt = ");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}

            Console.ReadKey();
        }
    }
}
