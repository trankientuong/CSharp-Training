using System;
using System.Collections.Generic;

namespace GenericHashSetDemo
{
    class Program
    {
        static void Main()
        {
            //Creating HashSet and Adding Elements to HashSet using Collection Initializer 
            HashSet<string> hashSetCountries = new HashSet<string>()
            {
                "Bangladesh",
                "Nepal"
            };
            //Adding Elements to HashSet using Add Method
            hashSetCountries.Add("INDIA");
            hashSetCountries.Add("USA");
            hashSetCountries.Add("UK");
            //Adding Duplicate Elements will not give compile time error
            //But duplicate elements are simply ignored and will not be added into the collection
            hashSetCountries.Add("UK");
            hashSetCountries.Add("INDIA");
            
            Console.WriteLine($"HashSet Elements Count Before Removing: {hashSetCountries.Count}");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }
            //Removing element Bangladesh from HashSet Using Remove() method
            hashSetCountries.Remove("Bangladesh");
            Console.WriteLine($"\nHashSet Elements Count After Removing Bangladesh: {hashSetCountries.Count}");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }
            //Remove Element from HashSet Using RemoveWhere() method where element length is > 3
            int NumberOfElementRemoved = hashSetCountries.RemoveWhere(x => x.Length > 3);
            Console.WriteLine($"\nHashSet Elements Count After Removeing {NumberOfElementRemoved} Elements : {hashSetCountries.Count}");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }
            //Remove All Elements Using Clear method
            hashSetCountries.Clear();
            Console.WriteLine($"\nHashSet Elements Count After Clear: {hashSetCountries.Count}");

            //Creating HashSet Collection1
            HashSet<string> hashSetCountries1 = new HashSet<string>();
            //Adding Elements to HashSet using Add Method
            hashSetCountries1.Add("IND");
            hashSetCountries1.Add("USA");
            hashSetCountries1.Add("UK");
            hashSetCountries1.Add("NZ");
            hashSetCountries1.Add("BAN");
            Console.WriteLine("HashSet 1 Elements");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Creating HashSet Collection2
            HashSet<string> hashSetCountries2 = new HashSet<string>();
            //Adding Elements to HashSet using Add Method
            hashSetCountries2.Add("IND");
            hashSetCountries2.Add("SA");
            hashSetCountries2.Add("SL");
            hashSetCountries2.Add("USA");
            hashSetCountries2.Add("ZIM");
            Console.WriteLine("\nHashSet 2 Elements");
            foreach (var item in hashSetCountries2)
            {
                Console.WriteLine(item);
            }
            // Using UnionWith method
            hashSetCountries1.UnionWith(hashSetCountries2);
             //Using IntersectWith method
            hashSetCountries1.IntersectWith(hashSetCountries2);
            //Using ExceptWith method
            //The ExceptWith method contains the elements from the first collection which are not present in the second collection.
            hashSetCountries1.ExceptWith(hashSetCountries2);
            //Using SymmetricExceptWith  method
            //The SymmetricExceptWith method contains elements that are not common in both collections.
            hashSetCountries1.SymmetricExceptWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }

            HashSet<Student> hashSetStudents = new HashSet<Student>()
            {
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                //Adding Dupliocate Element
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
                new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
            };
            Console.WriteLine("HashSet Students List");
            foreach (var item in hashSetStudents)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
            }

            Console.ReadKey();
        }
    }

    public class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public bool Equals(Student other)
        {
            return this.ID.Equals(other.ID);
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}   