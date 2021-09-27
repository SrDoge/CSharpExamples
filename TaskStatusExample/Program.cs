using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskStatusExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task<int>>();
            var source = new CancellationTokenSource();
            var token = source.Token;
            int completedIterations = 0;
            int forIteration = 2000000;


            for(int n = 0; n <= 19; n++)
            {
                tasks.Add(Task.Run(() =>
                {
                    int iterations = 0;
                    for (int ctr = 1; ctr <= forIteration; ctr++)
                    {
                        token.ThrowIfCancellationRequested();
                        iterations++;
                    }
                    Interlocked.Increment(ref completedIterations);
                    if (completedIterations >= 10) source.Cancel();
                    
                    return iterations;
                }, token));
            }

            Console.WriteLine("Esperando as 10 primeiras tasks concluírem...\n");

            try
            {
                Task.WaitAll(tasks.ToArray());
            }
            catch (AggregateException)
            {
                Console.WriteLine("Status das Tasks:\n");
                Console.WriteLine("{0,10} {1,20} {2,14,N0}" , "Task Id", "Status", "Iterações");

                foreach (var t in tasks)
                {
                    Console.WriteLine("{0,10} {1,20} {2,14}", 
                        t.Id, t.Status, 
                        t.Status != TaskStatus.Canceled ? t.Result.ToString("N0") : "n/a");
                }
            }
        }
    }
}
