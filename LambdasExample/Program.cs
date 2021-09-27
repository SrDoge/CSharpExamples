using System;
using System.Collections.Generic;
//using System.Linq;

namespace LambdasExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 3, 6, 5, 2, 11, 8, 7, 13 };

            //num.ToList().ForEach(i => Console.WriteLine($"Nº Impares: {i % 2 == 1}"));

            List<string> nomes = new List<string> { "Albe", "Bruce", "Chan", "Daniel", "Draco" };

            string result = nomes.Find(delegate (string nome)
            {
                return nome.StartsWith("D");
            });

            string resultLamb = nomes.Find(nome => nome.StartsWith("D"));

            Console.WriteLine(resultLamb);
            Console.ReadKey();
        }
    }
}
