using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_basic
{
    class Program
    {
        static void Main(string[] args)
        {

            Human denis = new Human("Denis","Lee","blue",28);
            denis.IntroduceMyself();

            Human Justin = new Human("Justin", "Liu", "black");
            Justin.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human Natalie = new Human("Natalie");
            Natalie.IntroduceMyself();

            Human Michael = new Human("Michael", "Miller");
            Michael.IntroduceMyself();

            Human Frank = new Human("Frank", "Walter", 29);
            Frank.IntroduceMyself();


            // create an object of my class
            // an instance of Human
            //Human michael = new Human();
            // access public variable from outside, and even change it
            //michael.firstName = "Mikel";
            //michael.lastName = "Lee";
            // call methods of the class
            //michael.IntroduceMyself();

            Console.Read();
        }
    }
}
