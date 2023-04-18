using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQSkipWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
            //Skip Numbers which are less than 5 using SkipWhile Method
            //Using Method Syntax
            List<int> ResultMS = numbers.SkipWhile(num => num < 5).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).SkipWhile(num => num < 5).ToList();
            //Accessing the Result using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}