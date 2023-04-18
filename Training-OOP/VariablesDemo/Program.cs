using System;
namespace VariablesDemo
{
    internal class Example
    {
        int x = 10;
        static void Main(string[] args)
        {
            Example e1 = new Example(); //e1 is Instance of class Example
            Example e2 = e1; //e2 is Reference of class Example
            Console.WriteLine($"e1.x: {e1.x} and e2.x: {e2.x}");
            e1.x = 50; //Modifying the x variable of e1 instance
            Console.WriteLine($"e1.x: {e1.x} and e2.x {e2.x}");
            e2.x = 150; //Modifying the x variable of e2 reference
            Console.WriteLine($"e1.x: {e1.x} and e2.x {e2.x}");
            Console.ReadKey();
        }
    }
}