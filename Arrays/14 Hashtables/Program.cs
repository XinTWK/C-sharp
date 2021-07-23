using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Hashtables
{
    class Program
    {
        // Key  -  Value
        // Auto -  Car

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student studnet1 = new Student(1, "Maria", 98);
            Student studnet2 = new Student(2, "Jason", 76);
            Student studnet3 = new Student(3, "Clera", 43);
            Student studnet4 = new Student(4, "Steve", 55);

            studentsTable.Add(studnet1.Id, studnet1);
            studentsTable.Add(studnet2.Id, studnet2);
            studentsTable.Add(studnet3.Id, studnet3);
            studentsTable.Add(studnet4.Id, studnet4);

            // retrieve individual item with know ID  檢索已知ID的項目
            Student storedStudent1 = (Student)studentsTable[studnet1.Id];

            // retrieve all valuers from a HashTable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID : {0}", temp.Id);
                Console.WriteLine("Student Name : {0}", temp.Name);
                Console.WriteLine("Student GPA : {0}", temp.GPA);

            }
            //Console.WriteLine("Student ID: {0}, Name:{1}, GPA: {2}",storedStudent1.Id,storedStudent1.Name,storedStudent1.GPA);

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID : {0}", value.Id);
                Console.WriteLine("Student Name : {0}", value.Name);
                Console.WriteLine("Student GPA : {0}", value.GPA);
            }


            Console.ReadKey();
        }
    }

    class Student
    {
        // property called id
        public int Id { get; set; }
        // property called Name
        public string Name { get; set; }
        // property called GPA
        public float GPA { get; set; }
        // simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;

        }



    }

}
