using System;
using System.Linq;
namespace LinqSum
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listStudents = new List<Employee>()
            {
                new Employee{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
                new Employee{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
                new Employee{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
                new Employee{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},
                new Employee{ID= 106,Name = "Sara", Salary = 25000, Department = "IT"},
                new Employee{ID= 107,Name = "Pranaya", Salary = 35000, Department = "IT"},
                new Employee{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new Employee{ID= 109,Name = "Sam", Salary = 45000, Department = "Sales"},
                new Employee{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}
            };
            return listStudents;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            //Using Method Syntax with a Predicate
            int MSTotal = intNumbers.Sum(num => {
                if (num > 50)
                    return num;
                else
                    return 0;
            });
            //Using Query Syntax with a Predicate
            int QSTotal = (from num in intNumbers
                           select num).Sum(num => {
                               if (num > 50)
                                   return num;
                               else
                                   return 0;
                           });
            Console.WriteLine("Sum = " + QSTotal);

            //Using Method Syntax and Predicate
            var TotalSalaryMS = Employee.GetAllEmployees()
                              .Sum(emp => {
                                  if (emp.Department == "IT")
                                      return emp.Salary;
                                  else
                                      return 0;
                              });
            
            Console.WriteLine("IT Department Total Salary = " + TotalSalaryMS);
            Console.ReadKey();
        }
    }
}