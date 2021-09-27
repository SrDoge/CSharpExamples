using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TasksExample
{
    class Example2
    {
        public static void MetodoTask()
        {
            //utilizando a propriedade Factory do tipo Task, recuperamos uma instância TaskFactory para criar uma tarefa para diversos propositos
            //O exemplo mostra como criar uma tarefa que executa uma ação, usando o método factory StartNew().
            var t = Task.Factory.StartNew(() => PrintConsole());
            Console.ReadKey();
        }

        private static void PrintConsole()
        {
            Console.WriteLine("Executando uma tarefa => PrintConsole() Task");
        }
    }
}
