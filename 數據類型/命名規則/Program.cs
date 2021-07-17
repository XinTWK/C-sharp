using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

https://www.dofactory.com/csharp-coding-standards  可以參考

namespace 命名規則
{   // class names like ClientActivity
    class Program
    {
        // Method name like CaculateValue
        // Method arguments like firstNumber
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl instead of usrCtr

            // don't use numbers at the start of Variable names


            // correct
            string myName;
            int lastNum;
            bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;


        }
    }
}
