using System.Collections.Generic;
namespace LINQPagingDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee() {ID = 1, Name = "Pranaya", Department = "IT" },
                new Employee() {ID = 2, Name = "Priyanka", Department = "IT" },
                new Employee() {ID = 3, Name = "Preety", Department = "IT" },
                new Employee() {ID = 4, Name = "Sambit", Department = "IT" },
                new Employee() {ID = 5, Name = "Sudhanshu", Department = "HR" },
                new Employee() {ID = 6, Name = "Santosh", Department = "HR" },
                new Employee() {ID = 7, Name = "Happy", Department = "HR" },
                new Employee() {ID = 8, Name = "Raja", Department = "IT" },
                new Employee() {ID = 9, Name = "Tarun", Department = "IT" },
                new Employee() {ID = 10, Name = "Bablu", Department = "IT" },
                new Employee() {ID = 11, Name = "Hina", Department = "HR" },
                new Employee() {ID = 12, Name = "Anurag", Department = "HR" },
                new Employee() {ID = 13, Name = "Dillip", Department = "HR" },
                new Employee() {ID = 14, Name = "Manoj", Department = "HR" },
                new Employee() {ID = 15, Name = "Lima", Department = "IT" },
                new Employee() {ID = 16, Name = "Sona", Department = "IT" },
            };
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            //We want to display 4 Records Per page
            int RecordsPerPage = 4;
            //Set the Initial Page Number as 0
            int PageNumber = 0;
            
            do
            {
                Console.WriteLine("\nEnter the Page Number Between 1 and 4");
                //Read the Value and if its integer type, then store that value in the PageNumber variable
                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    //Check if PageNumber is > 0 and < 5
                    if (PageNumber > 0 && PageNumber < 5)
                    {
                        //Logic to Implement Paging
                        var employees = Employee.GetAllEmployees() //Data Source
                                    .Skip((PageNumber - 1) * RecordsPerPage) //Skip Logic
                                    .Take(RecordsPerPage).ToList(); //Take Logic
                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter a Valid Page Number");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease Enter a Valid Page Number");
                }
            } while (true);
        }
    }
}