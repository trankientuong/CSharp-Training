using System.Collections.Generic;
using System.Linq;
namespace LINQFullOuterJoin
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
                new Employee { ID = 3, Name = "Anurag", DepartmentId = 0},
                new Employee { ID = 4, Name = "Pranaya", DepartmentId = 0},
                new Employee { ID = 5, Name = "Hina", DepartmentId = 10},
                new Employee { ID = 6, Name = "Sambit", DepartmentId = 30},
                new Employee { ID = 7, Name = "Mahesh", DepartmentId = 30}
            };
        }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"       },
                new Department { ID = 20, Name = "HR"       },
                new Department { ID = 30, Name = "Payroll"  },
                new Department { ID = 40, Name = "Admin"    },
                new Department { ID = 40, Name = "Sales"    }
            };
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var LeftOuterJoin = Employee.GetAllEmployees()
                                .GroupJoin(
                                    Department.GetAllDepartments(),
                                    employee => employee.DepartmentId,
                                    dept => dept.ID,
                                    (employee, department) => new 
                                    {
                                        employee, 
                                        department
                                    }
                                )
                                .SelectMany(
                                    x => x.department.DefaultIfEmpty(),
                                    (employee, department) => new 
                                    {
                                        EmployeeId = employee?.employee.ID,
                                        EmployeeName = employee?.employee.Name,
                                        DepartmentName = department != null ? department.Name : "N/A"
                                    }
                                );
            
            var RightOuterJoin = Department.GetAllDepartments()
                                .GroupJoin(
                                    Employee.GetAllEmployees(),
                                    dept => dept.ID,
                                    emp => emp.DepartmentId,
                                    (department, employee) => new 
                                    {
                                        department, 
                                        employee
                                    }
                                )
                                .SelectMany(
                                    x => x.employee.DefaultIfEmpty(),
                                    (department, employee) => new 
                                    {
                                        EmployeeId = employee?.ID,
                                        EmployeeName = employee != null ? employee.Name : "N/A",
                                        DepartmentName = department?.department.Name
                                    }
                                );

            var FullOuterJoin = LeftOuterJoin.Union(RightOuterJoin);

            foreach (var emp in FullOuterJoin)
            {
                Console.WriteLine($"EmployeeId: {emp.EmployeeId}, EmployeeName: {emp.EmployeeName} DepartmentName: {emp.DepartmentName}");
            }
        }
    }

}