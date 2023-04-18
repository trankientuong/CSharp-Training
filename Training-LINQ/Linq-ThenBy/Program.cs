using System.Collections.Generic;
namespace LinqThenBy
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
             //First Sort Students in Ascending Order Based on Branch
            //Then Sort Students in Descending Order Based on FirstName
            //Finally Sort Students in Ascending Order Based on LastName
            //Using Method Syntax
            var MS = Student.GetAllStudents()
                     .OrderBy(x => x.Branch)
                     .ThenByDescending(y => y.FirstName)
                     .ThenBy(z => z.LastName)
                     .ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetAllStudents()
                      orderby std.Branch ascending,
                              std.FirstName descending,
                              std.LastName //by default ascending
                      select std).ToList();
            foreach (var student in QS)
            {
                Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }

            //First, fetch only the CSE branch students
            //Sort the Students in ascending order based on First Name
            //Sort the students in descending order based on their Last Names
            //Using Method Syntax
            // var MS = Student.GetAllStudents()
            //          .Where(std => std.Branch == "CSE")
            //          .OrderBy(x => x.FirstName)
            //          .ThenByDescending(y => y.LastName)
            //          .ToList();
            // //Using Query Syntax
            // var QS = (from std in Student.GetAllStudents()
            //           where std.Branch == "CSE"
            //           orderby std.FirstName, //By Default it is Ascending
            //                   std.LastName descending
            //           select std).ToList();
            // foreach (var student in QS)
            // {
            //     Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            // }

            Console.ReadKey();
        }
    }
}