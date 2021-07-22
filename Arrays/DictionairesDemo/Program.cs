using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionairesDemo
{
    class Program
    {
        // key  -  value
        // Auto -  car
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lorq",32,21),
                new Employee("Sscretary","Pertra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8)

            };


            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two" },
                {3,"three" }
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            // Update
            string KeyToUpdate = "HR";
            if(employeeDirectory.ContainsKey(KeyToUpdate))
            {
                employeeDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updatede!",KeyToUpdate);
            }
            else
            {
                // if no print an error message
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }

            // Remove
            string KeyToRemove = "Intern";
            if(employeeDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!", KeyToRemove);
            }
            else
            {
                // if no print an error message
                Console.WriteLine("No employee found with this key {0}", KeyToRemove);

            }




            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0} , i is {1}", keyValuePair.Key, i);
                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing thje properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }


            string key = "CEO";
            if(employeeDirectory.ContainsKey(key))
            {
                Employee employee1 = employeeDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", employee1.Name, employee1.Role, employee1.Salary);
            }
            else
            {
                Console.WriteLine("NO employee found with this key {0}",key);
            }

            Employee result = null;
            // using TryGetValue() it returns true if the operation was successful and false otherwise
            if(employeeDirectory.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}",result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }






            Console.ReadKey();
        }
    }


    class Employee
    {
        // few properties like Role Name, Age and Rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly Salary = rate / h * number of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // simple constructor
        public Employee(string role,string name,int age,float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;


        }




    }

}
