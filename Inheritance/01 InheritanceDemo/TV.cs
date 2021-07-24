﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceDemo
{
    class TV : ElectricalDevice
    {
        // simple constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        // method to watch the TV
        public void WatchTV()
        {
            // first check if the TV is on
            if (IsOn)
            {
                // watch the TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                // print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
