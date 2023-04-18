﻿using System.Linq;
using System;
using System.Collections.Generic;
namespace LINQRepeatMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repeating the string value Welcome to DOT NET Tutorials for 10 Times
            //Using the Repeat Method
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}