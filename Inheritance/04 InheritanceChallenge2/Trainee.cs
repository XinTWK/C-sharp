﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InheritanceChallenge2
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours,int schoolHours,string name,string firstName,int salary) :base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Leran()
        {
            Console.WriteLine("I'm learning for {0} hours!",SchoolHours);
        }

        public void Work()
        {
            Console.WriteLine("I work for {0} hours",WorkingHours);
        }
    }
}