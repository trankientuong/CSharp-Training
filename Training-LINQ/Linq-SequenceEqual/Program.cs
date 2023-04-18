using System;
using System.Collections.Generic;
namespace LINQSequenceEqualDemo
{
    public class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetStudents1()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        public static List<Student> GetStudents2()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        //Implementing the Equals Method of IEquatable Interface
        public bool Equals(Student other)
        {
            return this.ID.Equals(other.ID) && this.Name.Equals(other.Name);
        }
        //Overriding the Object class GetHashCode Method
        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Collection 1 or Sequenece 1
            List<Student> StudentList1 = Student.GetStudents1();
            //Collection 1 or Sequenece 1
            List<Student> StudentList2 = Student.GetStudents2();
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            //Use the Overloaded version of the SequenceEqual method which does not take comparer parameter
            bool IsEqualMS = StudentList1.SequenceEqual(StudentList2);
            //Using Query Syntax
            //Use the Overloaded version of the SequenceEqual method which does not take comparer parameter
            bool IsEqualQS = (from std in StudentList1
                             select std) 
                             .SequenceEqual(StudentList2);
            //Printing the Result
            Console.WriteLine(IsEqualQS);
            Console.ReadLine();
        }
    }
}