using System;
using System.Linq;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}