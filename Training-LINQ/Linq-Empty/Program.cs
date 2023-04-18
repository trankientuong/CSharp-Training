using System.Linq;
using System.Collections.Generic;
using System;
namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> integerSequence = GetData() ?? Enumerable.Empty<int>(); ;
            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        private static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}