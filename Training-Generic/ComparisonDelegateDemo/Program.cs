using System;
using System.Collections.Generic;
namespace ComparisonDelegateDemo
{
    public class Program
    {
        public static void Main()
        {
            //Creating a List of Type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };
            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //Create an instance of the Comparison Delegate
            Comparison<Employee> employeeComparer = new Comparison<Employee>(CompareEmployees);
            //Passing Comparison Delegate as an argument to the Sort method
            listEmployees.Sort(employeeComparer);
            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            Console.ReadKey();

            // Sort by using Anonymous Method
            // listEmployees.Sort(delegate(Employee e1, Employee e2){
            //     return e1.Salary.CompareTo(e2.Salary);
            // });

            // Sort by using lambda expression
            // listEmployees.Sort((e1, e2) => { return e1.Name.CompareTo(e2.Name); });
            // listEmployees.Sort((Employee e1,Employee e2) => e1.Name.CompareTo(e2.Name));
        }
        //The following Method Signature must be the same as Comparison Delegate Signature
        //Write the Logic to Sort the Employee
        private static int CompareEmployees(Employee e1, Employee e2)
        {
            //Sorting the Employees Based on Name
            return e1.Name.CompareTo(e2.Name);
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