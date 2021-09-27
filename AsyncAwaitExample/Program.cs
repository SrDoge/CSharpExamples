using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {


        //Os métodos utilizando expressão de retorno "=>" (não é expressão Lambda) poderiam ser programados desse modo: 
        //private static decimal ExecutarAcao(int x, int y)
        //{
        //    return x + y;
        //}
        //mesmo resultado.

        private static decimal ExecutarAcao(int x, int y) => x + y;
        private static decimal ExecutarAcao2(int x, int y) => x / y;
        private static decimal ExecutarAcao3(int x, int y) => x * y;

        static void Main(string[] args)
        {
            //Tasks representam uma unidade de trabalho.

            var newTask = new Task[3];

            //Criando e enfileirando as tarefas utilizando o método Run().

            newTask[0] = Task.Run(() => ExecutarAcao(5, 5));
            newTask[1] = Task.Run(() => ExecutarAcao2(5, 5));
            newTask[2] = Task.Run(() => ExecutarAcao3(5, 5));

            //contador puramente ilustrativo
            var contador = 1;

            while (newTask.Any())
            {
                //aguardar a primeira tarefa ser finalizada (indice 0 do array) e salva na var
                var taskIndex = Task.WaitAny(newTask);

                //nova var(tipo task) recebe a primeira task que vai ser encerrada, indice 0 do array (biblioteca de consulta LINQ)
                var taskEncerrada = (Task<decimal>)newTask
                    .Where((newTask, index) => index == taskIndex)
                    .First();

                Console.WriteLine("Qtds de Task na variavel[]: " + newTask.Length);

                //newTask recebe ela mesma com uma nova quantidade de elementos, removendo a primeira task (indice 0 do array)
                //novamente utilizando a biblioteca de consulta LINQ
                newTask = newTask
                    .Where((newTask, index) => index != taskIndex)
                    .ToArray();

                //Propriedade result obtem o valor do resultado da task, quando deseja-se retornar o valor de uma Task<TResult>
                Console.WriteLine(
                    $@"Tarefa {contador++} Finalizada.
                    Estado: {taskEncerrada.Status} - 
                    Resultado: {taskEncerrada.Result}");
                Console.WriteLine("Qtds de Task na variavel[]: " + newTask.Length);
                Console.WriteLine("\n");
            }

        }

    }
}
