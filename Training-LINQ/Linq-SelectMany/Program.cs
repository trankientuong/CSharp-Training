using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqSelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MethodSyntax = Student.GetStudents()
                                            .SelectMany(std => std.Programming,
                                            (student, program) => new
                                            {
                                                StudentName = student.Name,
                                                ProgramName = program
                                            }
                                            )
                                            .ToList();
         
            //Using Query Syntax
            var QuerySyntax = (from std in Student.GetStudents()
                               from program in std.Programming
                               select new
                               {
                                   StudentName = std.Name,
                                   ProgramName = program
                               }).ToList();
            //Printing the values
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
            Console.ReadKey();
        }
    }
}