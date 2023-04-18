using System.Collections.Generic;
using System;
using System.Linq;
namespace LinqReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ArrayReversedData = intArray.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan"};
            Console.WriteLine("Before Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            // IEnumerable<string> ReverseData1 = stringList.AsEnumerable().Reverse();
            // IQueryable<string> ReverseData2 = stringList.AsQueryable().Reverse();

            //You cannot store the data like below as this method belongs to
            //System.Collections.Generic namespace whose return type is void
            //IEnumerable<int> ArrayReversedData = stringList.Reverse();
            stringList.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            
            Console.ReadKey();
        }
    }
}