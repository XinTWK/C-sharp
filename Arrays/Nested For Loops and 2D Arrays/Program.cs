using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_Loops_and_2D_Arrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine(" 1,2,3 ");
            Console.WriteLine(" 4,5,6 ");
            Console.WriteLine(" 7,8,9 ");


            Console.WriteLine("foreach print");
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            // Nested for loop
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) // 輸出偶數    if (matrix[i, j] % 2 == 1)  -> 輸出奇數
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("");
                }
            }
            Console.WriteLine(" \n Print diagonal value");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ( i == j) 
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
