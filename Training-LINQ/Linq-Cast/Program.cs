using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections;

namespace ConversionOperators
{
    class Program
    {
        public static void Main()
        {
            ArrayList list = new ArrayList
            {
                10,
                20,
                30,
            };

            //The following statement throws System.InvalidCastException
            list.Add("40");

            IEnumerable<int> result = list.Cast<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}