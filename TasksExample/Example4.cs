using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TasksExample
{
    class Example4
    {
        //Continuando tarefas
        //Usando a classe Task, podemos especificar que quando uma tarefa for concluida outra tarefa em especifico pode começar a execução
        //Exemplo: uma tarefa que usa o resultado anterior ou que deve fazer uma "limpeza" se a anterior falhou.

        public static void ContMultiTask()
        {
            //Criando um exemplo de uma continuação multitarefa que será executada quando 
            //qualquer uma das tarefas do array de tarefas tiverem sido concluidas.
            //PS: os laços de repetições são apenas ilustrativos, não fazem parte do exemplo original.
            Task<int>[] tarefas = new Task<int>[2];
            tarefas[0] = new Task<int>(() =>
            {
                return 34;
            });

            tarefas[1] = new Task<int>(() =>
            {
                return 8;
            });

            var conti = Task.Factory.ContinueWhenAll(
                tarefas, (antecedents) =>
                {
                    int resp = tarefas[0].Result + tarefas[1].Result;
                    Console.WriteLine("A resposta é {0}", resp);

                });

            for (int i = 0; i < tarefas.Length; i++)
            {
                Console.WriteLine(tarefas[i].Status);
            }

            //Chamando o método Start() em uma continuação no código do usuário resulta numa exceção "System.InvalidOperationException"*
            //*Normalmente é gerado quando o estado do objeto não pode dar suporte à chamada de método.
            tarefas[0].Start();
            tarefas[1].Start();

            for (int i = 0; i < tarefas.Length; i++)
            {
                Console.WriteLine(tarefas[i].Status);
            }

            //A continuação é somente uma tarefa e não bloqueia a thread onde é iniciada, 
            //por isso usamos Wait() para bloquear até a tarefa de continuação ser concluída.
            conti.Wait();

            for (int i = 0; i < tarefas.Length; i++)
            {
                Console.WriteLine(tarefas[i].Status);
            }
            Console.ReadKey();
        }
    }
}
