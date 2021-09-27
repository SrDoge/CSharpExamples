using System;
using System.Collections.Generic;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Peter");
            names.Add("Ben");
            names.Add("May");
            names.Add("Harry");

            names.ForEach(Print);

            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });

            void Print(string s)
            {
                Console.WriteLine(s);
            }


        }

        
    }
}
