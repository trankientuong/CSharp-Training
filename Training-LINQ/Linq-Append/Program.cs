using System.Linq;
using System.Collections.Generic;
using System;
namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of integer
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);
            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));
            // Creating a new sequence explicitly
            List<int> newintSequence = intSequence.Append(5).ToList();
            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));
            Console.ReadKey();
        }
    }
}