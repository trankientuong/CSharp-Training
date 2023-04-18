using System.Collections.Generic;
using System;
using System.Linq;
namespace LinqExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> AllStudents = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
                new Student {ID = 106, Name = "Santosh"},
            };
            List<Student> Class6Students = new List<Student>()
            {
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
            };
            
            //Method Syntax
            var MS = AllStudents.Select(x => new {x.ID, x.Name })
                    .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();
            //Query Syntax
            var QS = (from std in AllStudents
                      select new { std.ID, std.Name})
                      .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();
            
            foreach (var student in QS)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }
            
            Console.ReadKey();
        }
    }
}