namespace LinqOfType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            //Using Method Syntax
            var intData = dataSource.OfType<int>().Where(num => num > 30).ToList();
            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //Using Qyery Syntax
            var stringData = (from name in dataSource
                           where name is string && name.ToString().Length > 3
                           select name).ToList();
            foreach (string name in stringData)
            {
                Console.Write(name + " ");
            } 
            
            Console.ReadKey();
        }
    }
}