using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQTakeMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetching the First four elements from the Sequence where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Take(4).ToList();

            //Fetching the First four elements from the Sequence where Number > 2
            //Using Method Syntax
            // List<int> ResultMS = numbers.Take(4).Where(num => num > 2).ToList();
            
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Take(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}