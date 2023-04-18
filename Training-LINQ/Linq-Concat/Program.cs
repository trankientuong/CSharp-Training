using System.Linq;
using System;
using System.Collections.Generic;
namespace LinqConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Sources
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> { 2, 4, 6, 8 };
            //Using Concat Method
            var ConcatResult = sequence1.Concat(sequence2);
            Console.Write("Concat Method Result: ");
            foreach (var item in ConcatResult)
            {
                Console.Write(item + " ");
            }
            //Using Union Method
            var UnionResult = sequence1.Union(sequence2);
            Console.Write("\nUnion Method Result: ");
            foreach (var item in UnionResult)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}