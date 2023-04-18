using System.Collections.Generic;
namespace LinqOrderByDescending
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }

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
            //Method Syntax
            var MS = Student.GetAllStudents()
                            .Where(std => std.Branch.ToUpper() == "ETC")
                            .OrderByDescending(x => x.FirstName).ToList();
            //Query Syntax
            var QS = (from std in Student.GetAllStudents()
                      where std.Branch.ToUpper() == "ETC"
                      orderby std.FirstName descending
                      select std);
            foreach (var student in QS)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }

            // Using OrderBy overload with ICompare
            CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
            string[] Alphabets = { "a", "b", "c", "A", "B", "C"};
            var SortedAlphabets = Alphabets.OrderByDescending(aplhabet => aplhabet, caseInsensitiveComparer);
            foreach (var item in SortedAlphabets)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadKey();
        }
    }
}