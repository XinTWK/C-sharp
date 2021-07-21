using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of object 
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.36);
            myArrayList.Add(13);
            myArrayList.Add(129);
            myArrayList.Add(119.3);
            myArrayList.Add(13);

            // delete element with specific value from the arraylist
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            foreach(object obj in myArrayList)
            {

            }
            
        }
    }
}
