using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type
            // Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            // //Adding Elements to the Dictionary using Add Method of Dictionary class
            // dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            // dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            // dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");

            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };

            //Assign Values to a Dictionary with Indexer in C#
            dictionaryCountries["VN"] = "Vietnam";
            dictionaryCountries["SIN"] = "Singapore";

            //Update a Dictionary in C# using Indexer
            dictionaryCountries["SIN"] = "Singapure";

            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");    
            }
            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
            //Accessing Dictionary Elements using Keys
            Console.WriteLine("\nAccessing Dictionary Elements using Keys");
            Console.WriteLine($"Key: UK, Value: {dictionaryCountries["UK"]}");
            Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
            Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");

            //Checking the key using the ContainsKey methid
            Console.WriteLine("\nIs USA Key Exists : " + dictionaryCountries.ContainsKey("USA"));
            Console.WriteLine("Is PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + dictionaryCountries.ContainsValue("India"));
            Console.WriteLine("Is Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));

            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries.Count}");
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
                }
            }
            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");

            Console.ReadKey();
        }
    }
}