using System;

namespace SimpleDelegate
{
    //Declaração
    public delegate void SimplesDelegate();
    class Program
    {
        public static void minhaFunc()
        {
            Console.WriteLine("Chamado por um delegate...");
        }

        static void Main(string[] args)
        {

            //Instanciação
            SimplesDelegate simplesDelegate = new SimplesDelegate(minhaFunc);

            //Invocação
            simplesDelegate.Invoke();
            Console.ReadKey();

        }
    }
}
