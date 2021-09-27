using System;

namespace RefOutExample
{
    class Program
    {
        static void OutMethod(out int i)
        {
            i = 44;
        }

        static void RefMethod(ref int i)
        {
            i += 44;
        }
        static void Main(string[] args)
        {
            int valO, valR = 1;
            OutMethod(out valO);
            Console.WriteLine("Metodo Out " + valO);

            RefMethod(ref valR);
            Console.WriteLine("Metodo Ref " + valR);
        }
    }
}
