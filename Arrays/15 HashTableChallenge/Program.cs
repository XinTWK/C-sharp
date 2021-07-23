using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Chanllenge:
// Write a program that will iterate through each element of the students array and insert into a hashtable.
// If a student with the same ID already exists in the hashtable skip it and display the following error:
//   "Sorry, A student with the same ID already Exists".
// Hint: Use the method ContainsKey() to check wether a student with the same ID already exist

namespace _15_HashTableChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();



            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 86);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student s in students)
            {
                if (!studentsTable.ContainsKey(s.Id))
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine("Student with ID{0} was added!", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID already exists ID:{0}", s.Id);
                }
            }
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;

        }
    }
}
