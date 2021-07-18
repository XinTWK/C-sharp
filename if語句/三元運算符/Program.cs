using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元運算符
{
    class Program
    {
        static void Main(string[] args)
        {
            // [conditon] ? [first expression] : [second expression]
            // conditon has to be either true of false
            // The conditional Operator is right-associative
            // That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)
            // The conditional Operator cannot be overloaded.

            // 在攝氏度
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else if (temperature > 100)
                stateOfMatter = "gas";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            // in short:
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            // 挑戰: 增加 gas 狀態

            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";



            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();
        }
    }
}
