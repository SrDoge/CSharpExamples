using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TasksExample
{
    class Example3
    {
        //Continuando tarefas
        //Usando a classe Task, podemos especificar que quando uma tarefa for concluida outra tarefa em especifico pode começar a execução
        //Exemplo: uma tarefa que usa o resultado anterior ou que deve fazer uma "limpeza" se a anterior falhou.

        public static void ContTask()
        {
            //Criando uma continuaçao com o método Task.ContinueWith

            //Tarefa antecedente(anterior)
            Task<DayOfWeek> tarefaA = new Task<DayOfWeek>(() => DateTime.Today.DayOfWeek);

            //A continuação. Seu delegate toma a tarefa antecedente como argumento e pode retornar um tipo diferente
            Task<string> conti = tarefaA.ContinueWith((antecedent) =>
            {
                return String.Format("Today is {0}.", antecedent.Result);
            });

            //Inicia tarefa antecedente
            tarefaA.Start();

            //Usa o resultado da continuação
            Console.WriteLine(conti.Result);
            Console.ReadKey();

        }

    }
}
