using System;
using System.Linq;
namespace LinqDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentComparer studentComparer = new StudentComparer();


            //Using Method Syntax
            var MS = Student.GetStudents()
                    .Distinct(studentComparer).ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      select std)
                      .Distinct(studentComparer).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }
            Console.ReadKey();
        }
    }
}