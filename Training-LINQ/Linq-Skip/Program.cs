using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQSkipMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skipping the First four elements and Return Remaining Elements from the Sequence 
            //where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Skip(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Skip(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}