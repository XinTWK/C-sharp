﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(6);
            Console.WriteLine(t2.Equals(t1));

            Console.ReadKey();
        }
    }
}
