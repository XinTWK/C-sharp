using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 多維陣列

namespace Multi_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // 3D Array
            int[,,] threeD;

            // two dimensional Array
            int[,] array2D = new int[,]
            {
                {1,2,3 }, // row 0
                {4,5,6 }, // row 1
                {7,8,9 }  // row 2
            };

            Console.WriteLine("Central value is {0}",array2D[1,1]);
            Console.WriteLine("Bottom left value is {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" },
                    {"010","011" },
                    {"Hi there","What's up" }
                },
                {
                    {"100","101" },
                    {"110","111" },
                    {"Another one","Last entry" }
                }
            };
            Console.WriteLine("The value is {0}", array3D[1, 2, 1]);


            string[,] array2DString = new string[3, 2] { 
                { "one", "two" },
                { "three", "four" },
                { "five","six" }
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine("The value is {0}", array2DString[1, 1]);

            int dimension = array2DString.Rank;
            Console.WriteLine("The rank is {0}", dimension);

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };


            Console.ReadKey();
        }
    }
}
