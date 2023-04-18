using System.Collections.Generic;
using System;
using System.Linq;
namespace LinqUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            // string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            // //Method Syntax
            // var MS = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            // //Query Syntax
            // var QS = (from country in dataSource1
            //           select country)
            //           .Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            // foreach (var item in MS)
            // {
            //     Console.WriteLine(item);
            // }

            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
                new Student {ID = 107, Name = "Pranaya"},
                new Student {ID = 108, Name = "Santosh"},
            };
            //Method Syntax
            var MS = StudentCollection1.Select(x => x.Name)
                     .Union(StudentCollection2.Select(y => y.Name)).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std.Name)
                      .Union(StudentCollection2.Select(y => y.Name)).ToList();
            foreach (var name in MS)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}