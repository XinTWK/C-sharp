﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();


            Console.ReadKey();
        }
    }
}
