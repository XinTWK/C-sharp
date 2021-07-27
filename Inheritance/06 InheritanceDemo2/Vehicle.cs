using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritanceDemo2
{
    // base class for vehicles
    class Vehicle
    {
        // speed of the vehicle
        public float Speed { get; set; }

        // color of the vahicle
        public string Color { get; set; }

        // default constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        // simple constructor
        public Vehicle(float speed,string color)
        {
            Speed = speed;
            Color = color;
        }

    }
}
