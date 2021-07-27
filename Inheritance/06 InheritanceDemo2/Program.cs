using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritanceDemo2
{
    class Program 
    {
        static void Main(string[] args)
        {
            // creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            // add the two chairs to the IDestroyable list of the car
            // so thay when we destroy the car the destroyable objects
            // thay are near the car will get destroyed as well
            damagedCar.DestroyablesNeatby.Add(officeChair);
            damagedCar.DestroyablesNeatby.Add(gamingChair);

            // destroy the car
            damagedCar.Destroy();


            Console.ReadKey();
         }
    }
}
