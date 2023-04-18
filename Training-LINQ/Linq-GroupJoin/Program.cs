using System.Collections.Generic;
namespace LINQGroupJoin
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", DepartmentId = 10},
                new Employee { ID = 2, Name = "Priyanka", DepartmentId =20},
                new Employee { ID = 3, Name = "Anurag", DepartmentId = 30},
                new Employee { ID = 4, Name = "Pranaya", DepartmentId = 30},
                new Employee { ID = 5, Name = "Hina", DepartmentId = 20},
                new Employee { ID = 6, Name = "Sambit", DepartmentId = 10},
                new Employee { ID = 7, Name = "Happy", DepartmentId = 10},
                new Employee { ID = 8, Name = "Tarun", DepartmentId = 0},
                new Employee { ID = 9, Name = "Santosh", DepartmentId = 10},
                new Employee { ID = 10, Name = "Raja", DepartmentId = 20},
                new Employee { ID = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }
    }

    public class Program
    {
         class Program
    {
        static void Main(string[] args)
        {
            //Group Employees by Department using Method Syntax
            var GroupJoinMS = Department.GetAllDepartments(). //Outer Data Source i.e. Departments
                GroupJoin( //Performing Group Join with Inner Data Source
                    Employee.GetAllEmployees(), //Inner Data Source
                    dept => dept.ID, //Outer Key Selector  i.e. the Common Property
                    emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
                    (dept, emp) => new { dept, emp } //Projecting the Result to an Anonymous Type
                );
            //Printing the Result set
            //Outer Foreach is for Each department
            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a Particular department
                foreach (var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
            Console.ReadLine();
        }
    }
    } 
}