using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GetHashCode and Equals. 
//List vs. Dictionary
namespace ConsoleApp1
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public override int GetHashCode()
        {
            return EmpId;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else
            {
                var temp = obj as Employee;
                return temp.EmpId == this.EmpId && temp.Name == this.Name;
            }
        }
    }
        class InputOutputDemo
	{
        static void Main(string[] args)
        {
            //It is better than Array as arrays are fixed in size. 
            List<string> list = new List<string>();
            list.Add("Apples"); //Adds to the bottom of the List. 
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Insert(2, "Bananas");
            Console.WriteLine($"The count: {list.Count}");
            if (list.Remove("Oranges"))
                Console.WriteLine("The List has now removed " + "Oranges");
            Console.WriteLine($"The count: {list.Count}");

            //List<Employee> empList = new List<Employee>();
            //empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            //empList.Add(new Employee { EmpId = 112, Name = "Ramesh", Address = "Pune", Salary = 40000 });
            //empList.Add(new Employee { EmpId = 113, Name = "Sourav", Address = "Mumbai", Salary = 55000 });
            //empList.Add(new Employee { EmpId = 114, Name = "Aditya", Address = "Sholapur", Salary = 35000 });
            //Allows Duplicates. 

            //HashSet<string> set = new HashSet<string>();
            //set.Add("Apples");
            //set.Add("bananas");
            //set.Add("Apples");
            //Console.WriteLine("The count of fruits in this set is :" + set.Count);


            HashSet<Employee> empList = new HashSet<Employee>();
            empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            empList.Add(new Employee { EmpId = 111, Name = "Phaniraj", Address = "Bangalore", Salary = 45000 });
            empList.Add(new Employee { EmpId = 112, Name = "Ramesh", Address = "Pune", Salary = 40000 });
            empList.Add(new Employee { EmpId = 113, Name = "Sourav", Address = "Mumbai", Salary = 55000 });
            empList.Add(new Employee { EmpId = 114, Name = "Aditya", Address = "Sholapur", Salary = 35000 });
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.GetHashCode());
            }

            //Stores the data in the form of key-value pairs.
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("phani", "apple123");
            users.Add("rajesh", "apple123");
            users.Add("phani", "apple123");
            users.Add("phani", "apple123");
            users.Add("phani", "apple123");
            Console.WriteLine("Will this work?");
        }
    }
    //Write a program that has a class called Login and has functions called SignIn and SignUp. The functions should allow the users to signin or signup using Dictionary as data structure  
}
