using System;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace TaskCurrentIdExample
{
    class Program
    {
        static string beforeYield, afterYield, mainAsync, taskRun;
        static void Main(string[] args)
        {
            //var task = MainAsync(); output: null, null, 1
            //var task = Task.Run(() => MainAsync()); output: 1, null,2
            AsyncContext.Run(() => MainAsync());
            //task.Wait();

            //mainAsync = Task.Id.ToString();
            //taskRun = task.Id.ToString();

            Console.WriteLine($"{beforeYield}, {afterYield}");
            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            beforeYield = Task.CurrentId.HasValue ? Task.CurrentId.ToString() : "null";
            await Task.Yield();
            afterYield = Task.CurrentId.HasValue ? Task.CurrentId.ToString() : "null";

        }
    }
}
