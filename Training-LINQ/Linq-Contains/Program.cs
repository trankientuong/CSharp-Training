using System;
namespace LinqContains
{
    public class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public bool Equals(Student obj)
        {
            return this.ID == obj.ID && this.Name == obj.Name && this.TotalMarks == obj.TotalMarks;
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode() ^ this.TotalMarks.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
                        {
                            new Student(){ID = 101, Name = "Priyanka", TotalMarks = 275 },
                            new Student(){ID = 102, Name = "Preety", TotalMarks = 375 }
                        };
            //Using Method Syntax
            var IsExistsMS = students.Contains(new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 });
            var student1 = new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 };
            //Using Query Syntax
            var IsExistsQS = (from num in students
                              select num).Contains(student1);
            Console.WriteLine(IsExistsMS);
            Console.ReadKey();
        }
    }
}