using System;
using System.Collections;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){
                new Student(){ID = 1,Name = "Tran Kien Tuong",Gender = "Male"},
                new Student(){ID = 2,Name = "Dinh Quang Minh",Gender = "Male"},
                new Student(){ID = 3,Name = "Ta Thanh Phong",Gender = "Female"},
                new Student(){ID = 4,Name = "Le Hoang Bao",Gender = "Female"},
            };

           //Linq Query to Fetch all students with Gender Male
            // IEnumerable<Student> QuerySyntax = from std in students
            //                                    where std.Gender == "Male"
            //                                    select std;
            //Linq Method to Fetch all students with Gender Male
            IQueryable<Student> MethodSyntax = students.AsQueryable()
                                .Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach (var student in MethodSyntax)
            {
                Console.WriteLine( $"ID : {student.ID}  Name : {student.Name}");
            }

        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}