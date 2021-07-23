using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not.Hereby we even want to check, if it is a complete alphabetic entry(so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement.To check the valid string you can write your custom logic.

For example:

Enter a value: {here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer
*/


namespace _03_Foreach_loop_and_Switch_語句_挑戰
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;
            Console.WriteLine("here you can enter any value");
            string inputValue = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for Sting");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    // check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    // check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    Boolean retFlag = false;
                    // check for boolean
                    valid = Boolean.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknow";
                    Console.WriteLine("Not able to detect the input type, something is wrong");
                    break;
            }
            Console.WriteLine("You have entered a value: {0}", inputValue);

            if (valid)
            {
                Console.WriteLine("It is an valid : {0} ", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0} ", inputValueType);
            }

            Console.ReadKey();
        }


        /// <summary>
        /// function to check if the input string is valid string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>


        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
