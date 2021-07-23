using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2D_Arrays_小練習
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
            for (int i = 0; i < matrix.GetLength(0); i++) // this loop goes through each element in the diagonal
            {
                Console.WriteLine(matrix[i, i]); // 1 5 9
            }

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]); // 3 5 7
            }


            Console.ReadKey();
        }
    }
}
