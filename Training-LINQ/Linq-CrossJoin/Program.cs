using System.Collections.Generic;
namespace LINQCrossJoinDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety"},
                new Student { ID = 2, Name = "Priyanka"},
                new Student { ID = 3, Name = "Anurag"},
                new Student { ID = 4, Name = "Pranaya"},
                new Student { ID = 5, Name = "Hina"}
            };
        }
    }

    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var CrossJoinResult = Student.GetAllStudents()
                                  .SelectMany(sub => Subject.GetAllSubjects(),
                                    (std, sub) => new 
                                    {
                                        StudentName = std.Name,
                                        SubjectName = sub.SubjectName
                                    }
                                  );
            
            foreach(var item in CrossJoinResult)
            {
                Console.WriteLine($"Name: {item.StudentName}, Subject: {item.SubjectName}");
            }
        }
    }
}