using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
We have studied ternary operators and their usage so here is a small challenge for you.Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
*/

namespace if語句小挑戰3_三元運算符
{
    class Program
    {


        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // takes input fron console
            Console.WriteLine("請輸入溫度: ");
            inputValue = Console.ReadLine();

            // validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                // condition ? iftrue : iffalse;
                // if is valid integer then it will check for the conditions using nested ternary operator
                temperatureMessage = inputTemperature <= 15 ?
                    // true
                    "it is too cold here" :
                    // false
                    (inputTemperature >= 16 && inputTemperature <= 28) ? 
                    // true
                    "it is cold here" :
                    // false/
                    inputTemperature > 28 ?
                    // true
                    "it is hot here":
                    // false
                    "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                // in case if the input value is not a valid temperature
                Console.WriteLine("Not a valid Temperature");
            }

            Console.Read();
        }
    }
}
