using System;

namespace DelegateEH
{
    //Um delegate é um tipo que encapsula com segurança um método, semelhante a um ponteiro para funçoes em C e C++,
    //porem se diferenciam por serem orientados a objeto, referenciando um método.

    //Um evento é um membro que permite que um objeto ou classe forneça notificações.

    //Definir um EventHandler usando a palavra chave delegate para especificar o tipo do EventHandler
    public delegate void EventHandler();
    
    class Program
    {

        //A palavra chave event cria um evento, usado para criar uma instância de um.
        //Podendo armezanar métodos na sua lista de invocação.
        public static event EventHandler OnCalcular;

        static void Main(string[] args)
        {
            //Adiciona os EventHandles's ao evento OnCalcular
            OnCalcular += new EventHandler(Somar);
            OnCalcular += new EventHandler(Subtrair);
            OnCalcular += new EventHandler(Multiplicar);
            OnCalcular += new EventHandler(Multiplicar);

            //Invocação do evento
            OnCalcular.Invoke();
            Console.ReadLine();

            //Usando eventos podemos adicionar métodos que serão disparados em um evento externo.
        }

        private static void Multiplicar()
        {
            Console.WriteLine(String.Format(" 5 x 5 = {0}", 5 * 5));
        }

        private static void Subtrair()
        {
            Console.WriteLine(String.Format(" 5 - 5 = {0}", 5 - 5));
        }

        private static void Somar()
        {
            Console.WriteLine(String.Format(" 5 + 5 = {0}", 5 + 5));
        }
    }
}
