using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++) // 0 -> 0  1 -> 1
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1} ", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1} ", counter, k);
                counter++;
            }

            // create an array with 5 of your best friends
            // create a foreach loop which greets all of them

            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };
            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", name);
            }

            Console.ReadKey();
        }
    }
}
