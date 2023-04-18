using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Query Syntax
            var QuerySyntax = (from data in Employee.GetEmployees().Select((Data, index) => new { employee = Data, Index = index })
                               where data.employee.Salary >= 500000 && data.employee.Gender == "Male"
                               select new
                               {
                                   EmployeeName = data.employee.Name,
                                   Gender = data.employee.Gender,
                                   Salary = data.employee.Salary,
                                   IndexPosition = data.Index
                               }).ToList();
            //Method Syntax
            var MethodSyntax = Employee.GetEmployees().Select((Data, index) => new { employee = Data, Index = index })
                               .Where(emp => emp.employee.Salary >= 500000 && emp.employee.Gender == "Male")
                               .Select(emp => new
                               {
                                   EmployeeName = emp.employee.Name,
                                   Gender = emp.employee.Gender,
                                   Salary = emp.employee.Salary,
                                   IndexPosition = emp.Index
                               })
                               .ToList();
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Position : {emp.IndexPosition} Name : {emp.EmployeeName}, Gender : {emp.Gender}, Salary : {emp.Salary}");
            }
            Console.ReadKey();
        }
    }
}