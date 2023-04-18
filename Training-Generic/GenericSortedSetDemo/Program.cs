namespace GenericSortedSetDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating SortedSet and Adding Elements to SortedSet using Collection Initializer 
            SortedSet<string> sortedSetCountries = new SortedSet<string>()
            {
                "BANGLADESH",
                "NEPAL"
            };
            //Adding Elements to SortedSet using Add Method
            sortedSetCountries.Add("INDIA");
            sortedSetCountries.Add("USA");
            sortedSetCountries.Add("UK");
            Console.WriteLine($"SortedSet Elements Count Before Removing: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }
            // Remove element Bangladesh from SortedSet Using Remove() method
            sortedSetCountries.Remove("Bangladesh");
            Console.WriteLine($"\nSortedSet Elements Count After Removing Bangladesh: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }
            // Remove Element from SortedSet Using RemoveWhere() method where element length is > 3
            sortedSetCountries.RemoveWhere(x => x.Length > 3);
            Console.WriteLine($"\nSortedSet Elements Count After Removeing Elements whose Length > 3: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }
            // Remove all Elements from SortedSet Using Clear method
            sortedSetCountries.Clear();
            Console.WriteLine($"\nSortedSet Elements Count After Clear: {sortedSetCountries.Count}");

            SortedSet<Student> sortedSetStudents = new SortedSet<Student>()
            {
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                new Student(){ ID = 101, Name ="Any Value", Branch="Any Value"},
                new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
                new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
            };
            Console.WriteLine("SortedSet Students List");
            foreach (var item in sortedSetStudents)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
            }
            Console.ReadKey();
        }
    }

    public class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public int CompareTo(Student other)
        {
            if (this.ID > other.ID)
            {
                return 1;
            }
            else if (this.ID < other.ID)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}