using System;
using System.Collections.Generic;
namespace ListCollectionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create Employee Objects
            Employee Employee1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee Employee2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee Employee3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };
            Employee Employee4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                Employee1,
                Employee2,
                Employee3,
                Employee4
            };
            // use Contains method to check if an item exists or not in the list 
            Console.WriteLine("Contains Method Check Employee2 Object");
            if (listEmployees.Contains(Employee2))
            {
                Console.WriteLine("Employee2 Object Exists in the List");
            }
            else
            {
                Console.WriteLine("Employee2 Object Does Not Exists in the List");
            }
            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            Console.WriteLine("\nExists Method Name StartsWith P");
            if (listEmployees.Exists(x => x.Name.StartsWith("P")))
            {
                Console.WriteLine("List contains Employees whose Name Starts With P");
            }
            else
            {
                Console.WriteLine("List does not Contain Any Employee whose Name Starts With P");
            }
            // Use Find() method, if you want to return the First Matching Element by a conditions 
            Console.WriteLine("\nFind Method to Return First Matching Employee whose Gender = Male");
            Employee? emp = listEmployees.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {emp?.ID}, Name = {emp?.Name}, Gender = {emp?.Gender}, Salary = {emp?.Salary}");
            // Use FindLast() method when you want to searche an item by a conditions and returns the Last matching item from the list
            Console.WriteLine("\nFindLast Method to Return Last Matching Employee whose Gender = Male");
            Employee? lastMatchEmp = listEmployees.FindLast(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {lastMatchEmp?.ID}, Name = {lastMatchEmp?.Name}, Gender = {lastMatchEmp?.Gender}, Salary = {lastMatchEmp?.Salary}");
            // Use FindAll() method when you want to return all the items that matches the conditions
            Console.WriteLine("\nFindAll Method to return All Matching Employees Where Gender = Male");
            List<Employee> filteredEmployees = listEmployees.FindAll(employee => employee.Gender == "Male");
            foreach (Employee femp in filteredEmployees)
            {
                Console.WriteLine($"ID = {femp.ID}, Name = {femp.Name}, Gender = {femp.Gender}, Salary = {femp.Salary}");
            }
            
            // Use FindIndex() method when you want to return the index of the first item by a condition
            Console.WriteLine($"\nIndex of the First Matching Employee whose Gender is Male = {listEmployees.FindIndex(employee => employee.Gender == "Male")}");
            
            // Use FindLastIndex() method when you want to return the index of the last item by a condition
            Console.WriteLine($"Index of the Last Matching Employee whose Gender is Male = {listEmployees.FindLastIndex(employee => employee.Gender == "Male")}");
            Console.ReadKey();
        }
    }

    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}