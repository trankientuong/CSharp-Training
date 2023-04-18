using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source: Numbers are Stored in Randon Order
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
            //Using TakeWhile Method to Fetch Numbers which are less than 6
            List<int> Result1 = numbers.TakeWhile(num => num < 6).ToList();
            Console.Write("Result Of TakeWhile Method: ");
            foreach (var num in Result1)
            {
                Console.Write($"{ num} ");
            }
            Console.WriteLine();
            //Using Where Method to Fetch Numbers which are less than 6
            List<int> Result2 = numbers.Where(num => num < 6).ToList();
            Console.Write("Result Of Where Method: ");
            foreach (var num in Result2)
            {
                Console.Write($"{ num} ");
            }
            Console.ReadKey();
        }
    }
}