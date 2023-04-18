using System;
using System.Collections.Generic;
namespace GenericSortedDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            //Here we are creating a genericSortedDictionary whose key is int and value is Student
            SortedDictionary<int, Student> genericSortedDictionary = new SortedDictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 104, new Student(){ ID = 104, Name ="Pranaya", Branch="ETC"}},
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}}
            };
            //The following Statement will give you Runtime Exception as the key is already exists
            //System.ArgumentException: 'An entry with the same key already exists.'
            //genericSortedDictionary.Add(101, new Student() { ID = 101, Name = "Anurag", Branch = "CSE" });
            //Accessing Generic SortedDictionary Collection using For Each loop
            Console.WriteLine("Generic SortedDictionary Collection Elements");
            foreach (KeyValuePair<int, Student> item in genericSortedDictionary)
            {
                Console.WriteLine($"Key: { item.Key}: ID: { item.Value.ID}, Name: { item.Value.Name}, Branch: { item.Value.Branch}");
            }
            Console.ReadKey();
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}