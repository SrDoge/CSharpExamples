using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOperations
{
    public class ToList
    {
        public static void Method()
        {
            string[] fruits = {"apple", "passionfruit", "banana", "mango",
                      "orange", "blueberry", "grape", "strawberry"};

            List<int> lengths = fruits.Select(fruit => fruit.Length).ToList();

            foreach (var length in lengths)
            {
                Console.WriteLine(length);
            }
        }

    }
}
