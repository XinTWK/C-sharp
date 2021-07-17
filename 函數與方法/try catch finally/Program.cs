using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Can't divide by zero!");
            }
           


            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exceptionm please enter the correct type next time.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value is empty(null)");
            }finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.Read();
        }
    }
}
