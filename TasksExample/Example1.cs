using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TasksExample
{
    class Example1
    {
        public static void MetodoTask()
        {
            Console.WriteLine("executando uma tarefa (task)");
            Console.WriteLine("Task id: {0}", Task.CurrentId);
        }
    }
}
