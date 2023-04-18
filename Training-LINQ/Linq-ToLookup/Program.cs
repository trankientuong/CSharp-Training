using System.Collections.Generic;
using System.Linq;

namespace ToLookupDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age = 20 },
                new Student { ID = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age = 21  },
                new Student { ID = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age = 21  },
                new Student { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
                new Student { ID = 1005, Name = "Hina", Gender = "Female", Branch = "ETC", Age = 20 },
                new Student { ID = 1006, Name = "Priyanka", Gender = "Female", Branch = "CSE", Age = 21 },
                new Student { ID = 1007, Name = "santosh", Gender = "Male", Branch = "CSE", Age = 22  },
                new Student { ID = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age = 20  },
                new Student { ID = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age = 22 },
                new Student { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 21 }
            };
        }
    }

    public class StudentGroupByBranchAndGender
    {
        public string Branch { get; set; }
        public string Gender { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var GroupByMultipleKeysMS = Student.GetStudents()
                                        //Group the Students first by Branch and then by Gender using ToLookup
                                        .ToLookup(x => new { x.Branch, x.Gender })
                                        //Sort Each Group in Descending Order Based on Branch
                                        .OrderByDescending(g => g.Key.Branch)
                                        //Then Sort Each Branch Group in Ascending Order Based on Gender
                                        .ThenBy(g => g.Key.Gender)
                                        //Project the Result to an Annonymous Type
                                        .Select(g => new StudentGroupByBranchAndGender
                                        {
                                            Branch = g.Key.Branch,
                                            Gender = g.Key.Gender,
                                            //Sort the Students of Each group by Name in Ascending Order
                                            Students = g.OrderBy(x => x.Name).ToList()
                                        });
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysMS)
            {
                Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}