using System.Collections.Generic;
namespace GroupByDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1001, Name = "Preety", Gender = "Female", Barnch = "CSE", Age = 20 },
                new Student { ID = 1002, Name = "Snurag", Gender = "Male", Barnch = "ETC", Age = 21  },
                new Student { ID = 1003, Name = "Pranaya", Gender = "Male", Barnch = "CSE", Age = 21  },
                new Student { ID = 1004, Name = "Anurag", Gender = "Male", Barnch = "CSE", Age = 20  },
                new Student { ID = 1005, Name = "Hina", Gender = "Female", Barnch = "ETC", Age = 20 },
                new Student { ID = 1006, Name = "Priyanka", Gender = "Female", Barnch = "CSE", Age = 21 },
                new Student { ID = 1007, Name = "santosh", Gender = "Male", Barnch = "CSE", Age = 22  },
                new Student { ID = 1008, Name = "Tina", Gender = "Female", Barnch = "CSE", Age = 20  },
                new Student { ID = 1009, Name = "Celina", Gender = "Female", Barnch = "ETC", Age = 22 },
                new Student { ID = 1010, Name = "Sambit", Gender = "Male",Barnch = "ETC", Age = 21 }
            };
        }
    }

    public class StudentGroup
    {
        public string Key { get; set; }
        public List<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
             //Using Method Syntax
                            //First Group the Data by Gender
            var GroupByMS = Student.GetStudents().GroupBy(s => s.Gender)
                            //Then Sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new StudentGroup
                            {
                                Key = std.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = std.OrderBy(x => x.Name).ToList()
                            });
            //Using Query Syntax
            //First Group the Data by Gender
            var GroupByQS = from std in Student.GetStudents()
                            //First store the data into a group
                            group std by std.Gender into stdGroup
                            //Then Sorting the data based on key in Descending Order
                            orderby stdGroup.Key descending
                            select new StudentGroup
                            {
                                Key = stdGroup.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = stdGroup.OrderBy(x => x.Name).ToList()
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                //Iterate through each student of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
                }
            }
            Console.Read();
        }
    }
}