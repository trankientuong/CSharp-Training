using System.Collections.Generic;
using System.Linq;
namespace LinqAll
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }
        public static List<Student> GetAllStudnets()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student
                {
                    ID= 101,
                    Name = "Preety",
                    TotalMarks = 265,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
                },
                new Student{ID= 102,Name = "Priyanka", TotalMarks = 278,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 95},
                        new Subject(){SubjectName = "English", Marks = 93}
                    }},
                new Student{ID= 103,Name = "James", TotalMarks = 240,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 70},
                        new Subject(){SubjectName = "Science", Marks = 80},
                        new Subject(){SubjectName = "English", Marks = 90}
                    }},
                new Student{ID= 104,Name = "Hina", TotalMarks = 275,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }},
                new Student{ID= 105,Name = "Anurag", TotalMarks = 255,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 85}
                    }
                },
            };
            return listStudents;
        }
    }
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Marks { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            bool MSResult = Student.GetAllStudnets().All(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSResult = (from std in Student.GetAllStudnets()
                             select std).All(std => std.TotalMarks > 250);
            Console.WriteLine($"Is All Students Having Total Marks 250: {MSResult}");

            var marksStudent = Student.GetAllStudnets().Where(x => x.Subjects.All(x => x.Marks > 80)).ToList();
            
            foreach (var student in marksStudent)
            {
                Console.WriteLine($"{student.Name} - {student.TotalMarks}");
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
            }

            Console.ReadKey();
        }
    }
}