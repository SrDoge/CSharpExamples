using System;
using System.Collections;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Stack s = new Stack();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(2.5);
            q.Enqueue("três");

            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine("Listando elementos da Fila:");
#if DEBUG
            Console.WriteLine("Debugando");
#endif
            while (q.Count > 0) 
            {
                Console.WriteLine(q.Dequeue());
            }
            Console.WriteLine();
            Console.WriteLine($"A fila possui {q.Count} elementos agora.\n");
            Console.ReadKey();

            Console.WriteLine("Listando elementos da Pilha:");
            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine();
            Console.WriteLine($"A Pilha possui {s.Count} elementos agora.");
            Console.Read();
        }
    }
}
