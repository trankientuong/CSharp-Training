using System.Linq;
using System;
using System.Collections.Generic;
namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Range with Where Extension Method
            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 40).Where(x => x % 2 == 0);
            // IEnumerable<int> EvenNumbers = Enumerable.Range(1, 5).Select(x => x*x);
            //Printing the Even Numbers between 10 and 40
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }

            IEnumerable<string> rangewithString = Enumerable.Range(1, 5).Select(x => (x * x) + " " + CustomLogic(x)).ToArray();
            foreach (var item in rangewithString)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    private static string CustomLogic(int x)
        {
            string result = string.Empty;
            switch (x)
            {
                case 1:
                    result = "1st";
                    break;
                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "3rd";
                    break;
                case 4:
                    result = "4th";
                    break;
                case 5:
                    result = "5th";
                    break;
            }
            return result;
        }
    }
}