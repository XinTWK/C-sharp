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
                    Console.Write(matrix[i,j] + " ");
                }
            }


            Console.ReadKey();
        }
    }
}
