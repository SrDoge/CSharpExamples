using System;

namespace EnumExample
{
    class Program
    {
        enum Colors { Red, Green, Blue, Yellow};
        enum Styles { Plaid = 0, Striped = 23, Tartan = 65, Corduroy = 78};

        static void Main(string[] args)
        {
            Console.WriteLine("Os valores do Enum (Colors) são:");
            foreach (int item in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Os valores do Enum (Styles) são:");
            foreach (string i in Enum.GetNames(typeof(Styles))) 
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
