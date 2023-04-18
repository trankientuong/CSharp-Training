using System;
using System.Collections.Generic;
namespace GenericSortedListDemo
{
    class Program
    {
        static void Main()
        {
            //Creating Generic SortedList Collection
            SortedList<int, string> genericSortedList = new SortedList<int, string>();
            //Adding Elements to SortedList Collection using Add Method in Random Order
            genericSortedList.Add(1, "One");
            genericSortedList.Add(5, "Five");
            genericSortedList.Add(4, "Four");
            genericSortedList.Add(2, "Two");
            genericSortedList.Add(3, "Three");
            //You cannot pass null as a key
            //genericSortedList.Add(null, "Ten"); //Compile-Time Error
            //Duplicate Key not allowed
            //System.ArgumentException: 'An entry with the same key already exists.'
            //genericSortedList.Add(2, "Any Value");
            //Accessing Generic SortedList Collection using For loop
            Console.WriteLine("Accessing Generic SortedList using For loop");
            for (int i = 0; i < genericSortedList.Count; i++)
            {
                Console.WriteLine("Keys : " + genericSortedList.Keys[i] + "\tValues : " + genericSortedList.Values[i]);
            }
            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("\nAccessing SortedList using For Each loop");
            foreach (KeyValuePair<int, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
            }
            //Accessing Generic SortedList Individual Elements using Keys
            Console.WriteLine("\nAccessing SortedList Individual Elements using Keys");
            Console.WriteLine($"Key: 1, Value: {genericSortedList[1]}");
            Console.WriteLine($"Key: 2, Value: {genericSortedList[2]}");
            Console.WriteLine($"Key: 3, Value: {genericSortedList[3]}");

            // Remove value having key 1 using Remove() method
            genericSortedList.Remove(1);
            Console.WriteLine($"\nSortedList Elements After Remove Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            foreach (KeyValuePair<int, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
            }

            // Remove element at index 1 using RemoveAt() method
            genericSortedList.RemoveAt(1);
            Console.WriteLine($"\nSortedList Elements After RemoveAT Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            foreach (KeyValuePair<int, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: { item.Key}, Value: { item.Value}");
            }

            // Remove all key/value pairs Using Clear method
            genericSortedList.Clear();
            Console.WriteLine($"After Clear Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");

            Console.ReadKey();
        }
    }
}