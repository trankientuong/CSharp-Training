using System.Linq;
using System;
using System.Collections.Generic;
namespace LINQSingleMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequence contains
            List<int> numbers = new List<int>() { 10, 20, 30 };
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element > 10
            int numberMS = numbers.SingleOrDefault(num => num > 10);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element > 10
            int numberQS = (from num in numbers
                           select num).SingleOrDefault(num => num > 10);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
            Console.ReadLine();
        }
    }
}