using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串操作
{
    class Program
    {
        static void Main(string[] args)
        {
            // define few variables
            int age = 31;
            string name = "alfonso";
            string job = "Deeloper";

            // 1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");
            

            // 2. String formatting
            // String formatting uses index
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}" , name , age, job);

            // 3. String interpolation
            // Sting Interpolation uses $ at the start which will allow us to write our
            // variables like this {variavleName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old");

            // 4. Verbatim strings
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit anet, 
            dsjaiodjasoidjfhiew  dsajidoasj  djsaiodjsaoidjaso. djisaojdoahjtrouigds

            dsadasuhidahsu");

            // instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you will get a error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\user\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            // with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!.");
            Console.WriteLine("Muahaha \n you have powers here!.");

            Console.Read();



        }
    }
}
