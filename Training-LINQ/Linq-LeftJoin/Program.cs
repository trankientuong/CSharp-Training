using System.Collections.Generic;
using System.Linq;

namespace LINQLeftOuterJoin
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1},
                new Employee { ID = 2, Name = "Priyanka", AddressId =2},
                new Employee { ID = 3, Name = "Anurag", AddressId = 0},
                new Employee { ID = 4, Name = "Pranaya", AddressId = 0},
                new Employee { ID = 5, Name = "Hina", AddressId = 5},
                new Employee { ID = 6, Name = "Sambit", AddressId = 6}
            };
        }
    }

    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAddress()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 6, AddressLine = "AddressLine6"},
            };
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Performing Left Outer Join using LINQ using Query Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            // var QSOuterJoin = from emp in Employee.GetAllEmployees() // Left Data Source
            //                   join add in Address.GetAddress()  // Right Data Source
            //                   on emp.AddressId equals add.ID // Inner Join Condition
            //                   into EmployeeAddressGroup  // Performing LINQ Group Join
            //                   from address in EmployeeAddressGroup.DefaultIfEmpty() // Performing Left Outer Join
            //                   select new {emp, address}; // Projecting the Result to Anonymous Type
            
            //  //Accessing the Elements using For Each Loop
            // foreach (var item in QSOuterJoin)
            // {
            //     //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
            //     Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            // }

            //Performing Left Outer Join using LINQ using Method Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            var MSLeftOuterJOIN = Employee.GetAllEmployees() //Left Data Source
                              //Performing Group join with Right Data Source
                              .GroupJoin(
                                    Address.GetAddress(), //Right Data Source
                                    employee => employee.AddressId, //Outer Key Selector, i.e. Left Data Source Common Property
                                    address => address.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (employee, address) => new { employee, address } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.address.DefaultIfEmpty(), //Performing Left Outer Join 
                                    (employee, address) => new 
                                    { 
                                        employeeName = employee.employee.Name, 
                                        addressLine = address != null ? address.AddressLine : "N/A" 
                                    } //Final Result Set
                               );
            //Accessing the Elements using For Each Loop
            foreach (var item in MSLeftOuterJOIN)
            {
                Console.WriteLine($"Name : {item.employeeName}, Address : {item.addressLine} ");
            }

            Console.WriteLine();

            //Performing Right Outer Join using LINQ using Query Syntax
            //Changing the Data Sources
            //Left Data Source: Addresses 
            //Right Data Source: Employees
            //Note: Left and Right Data Source Matters
            var MSRightOuterJoin = Address.GetAddress()
                                    //Performing Group Join with Left Data Source
                                    .GroupJoin(
                                        Employee.GetAllEmployees(),
                                        address => address.ID,
                                        employee => employee.AddressId,
                                        (address, employee) => new { address, employee } // Projecting the Result
                                    )
                                    .SelectMany(
                                        x => x.employee.DefaultIfEmpty(),
                                        (add, employee) => new 
                                        {
                                            address = add.address,
                                            employee = employee
                                        }
                                    );
            
            foreach (var item in MSRightOuterJoin)
            {
                Console.WriteLine($"Name: {item.employee?.Name}, Address: {item.address.AddressLine}");
            }

            Console.ReadLine();
        }
    }
}