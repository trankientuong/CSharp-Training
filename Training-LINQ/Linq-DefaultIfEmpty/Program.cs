using System.Collections.Generic;
namespace LINQDefaultIfEmptyMethodDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", Salary = 10000, Gender = "Female"},
                new Employee { ID = 2, Name = "Priyanka", Salary =20000, Gender = "Female"},
                new Employee { ID = 3, Name = "Anurag", Salary = 35000, Gender = "Male"},
                new Employee { ID = 4, Name = "Pranaya", Salary = 45000, Gender = "Male"}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Sequence is not empty
            List<Employee> employees = Employee.GetAllEmployees();
            //Create an Employee Object to pass into the DefaultIfEmpty method incase the sequence is Empty
            Employee emp5 = new Employee() { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female" };
            //DefaultIfEmpty Method will return the Original Sequence values
            //as the Sequence is not Empty
            //Using Method Syntax
            IEnumerable<Employee> resultMS = employees.DefaultIfEmpty(emp5);
            //Using Query Syntax
            IEnumerable<Employee> resultQS = (from employee in employees
                                         select employee).DefaultIfEmpty(emp5);
            //Accessing the new sequence values using for each loop
            foreach (Employee emp in resultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary} ");
            }
            Console.ReadLine();
        }
    }
}