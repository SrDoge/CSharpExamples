using System;
using System.Threading;

namespace ThreadPoolExample
{
    class Program
    {
        static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("I'm a worker from ThreadPool");
            Thread.Sleep(1000);
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(BackgroundTask);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(500);
            
            Console.WriteLine("Main thread exits.");
            Console.ReadKey();
        }
    }
}
