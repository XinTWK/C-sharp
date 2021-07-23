﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };

            //var friends = new List<string>();

            var partyFriends = GetPartyFriends(friends, 10);

            // test and debug
            //foreach (var name in friends)
            //{
            //    Console.WriteLine(name);
            //}
            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            //if (list == null)
            //    throw new ArgumentNullException("List", "The list is empty");

            //if (count > list.Count || count <= 0)
            //    throw new ArgumentOutOfRangeException("count", "Count cannot be greater then elements in the list");

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();
            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }

        /// <summary>
        /// this is the logic to figure out who is a party
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;

        }
    }
}
