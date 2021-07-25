﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            // another way of initiallizing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way of initiallizeing an array
            int[] gradesOfMathStudentB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentA: {0}", gradesOfMathStudentsA.Length);




            Console.ReadKey();
        }
    }
}