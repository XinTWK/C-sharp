using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_IEnumerableAndIEnumeratorDemo
{
    class Program
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections

        /// <summary>
        ///  IEnumerable<T> contains a single method that you must implement when implementing this interface;
        ///  GetEnumerator(), thich returns an IEnumerator<T> object.
        ///  The returned IEnumerable<T> provides the ability through the collection
        ///  by expsoing a Current property that points at the object we are currently at in the collection.
        /// </summary>


        ///  when it is recommended to use the IEnumerable interface:
        ///  - Your collection represents a massive database table,
        ///  you don't want to copy the entire thing into memory and cause performance issues in your application.
        ///  When it is not recommended to use the IEnumerable interface:
        ///  You need the results right away and are possibly mutating / editing the objects later on.
        ///  In this class,it is better to  use an Array or a List


        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }



        }
    }

    class Dog
    {
        // the name of the dog
        public string Name { get; set; }

        // is this a naughty dog
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // this method will print how many traets the dog received
        public void GiveTreat(int numberofTreats)
        {
            // print a message containing the number of treats and the name of the dog
            Console.WriteLine("Dog: {0} siad wuoff {1} times!", Name, numberofTreats);
        }

    }

    // a class name DogShelter this calss contains a gerneric collection of type Dog
    // objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface

    class DogShelter : IEnumerable<Dog>
    {
        // list of type List<Dog>
        public List<Dog> dogs;

        // this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            // initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oreo",false),
                new Dog("Pixel",false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotFiniteNumberException();
        }
    }
}