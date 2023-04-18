using System.Collections.Generic;
namespace LINQFirstOrDefaultMethodDemo
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
                new Employee { ID = 4, Name = "Pranaya", Salary = 45000, Gender = "Male"},
                new Employee { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female"},
                new Employee { ID = 6, Name = "Sambit", Salary = 30000, Gender = "Male"},
                new Employee { ID = 7, Name = "Mahesh", Salary = 35600, Gender = "Male"}
            };
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<Employee> listEmployees = Employee.GetAllEmployees();
            //Fetching the First Employee from listEmployees Collection
            Employee Employee1 = listEmployees.First();
            Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");
            //Fetch the First Employee where the Gender is Male
            Employee Employee2 = listEmployees.First(emp => emp.Gender == "Male");
            Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");
            //Fetch the First Employee where the Salary is less than 30000
            Employee Employee3 = listEmployees.First(emp => emp.Salary < 30000);
            Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
            Console.ReadLine();
        }
    }
}