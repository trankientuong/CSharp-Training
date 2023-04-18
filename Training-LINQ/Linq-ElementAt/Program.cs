using System.Collections.Generic;
namespace LINQElementAtOrDefaultDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety", Department= "IT"},
                new Student { ID = 2, Name = "Priyanka", Department= "HR"},
                new Student { ID = 3, Name = "Anurag", Department= "HR"},
                new Student { ID = 4, Name = "Pranaya", Department= "IT"},
                new Student { ID = 5, Name = "Hina", Department= "IT"}
            };
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            //ElementAtOrDefault Method Syntax
            Student ElementAtMS = Student.GetAllStudents().ElementAt(1);
            //ElementAtOrDefault Query Syntax
            Student ElementAtQS = (from student in Student.GetAllStudents()
                                   select student).ElementAt(2);
            //ElementAtOrDefault Method Syntax
            Student ElementAtOrDefaultMS = Student.GetAllStudents().ElementAtOrDefault(0);
            //ElementAtOrDefault Query Syntax
            Student ElementAtOrDefaultQS = (from student in Student.GetAllStudents()
                                   select student).ElementAtOrDefault(3);
            Console.WriteLine($"ID: {ElementAtMS.ID}, Name: {ElementAtMS.Name}, Department: {ElementAtMS.Department}");
            Console.WriteLine($"ID: {ElementAtQS.ID}, Name: {ElementAtQS.Name}, Department: {ElementAtQS.Department}");
            Console.WriteLine($"ID: {ElementAtOrDefaultMS.ID}, Name: {ElementAtOrDefaultMS.Name}, Department: {ElementAtOrDefaultMS.Department}");
            Console.WriteLine($"ID: {ElementAtOrDefaultQS.ID}, Name: {ElementAtOrDefaultQS.Name}, Department: {ElementAtOrDefaultQS.Department}");
            Console.ReadLine();
        }
    }
}