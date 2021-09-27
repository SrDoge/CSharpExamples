using System;

namespace DemoEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Demo de um evento simples ###");

            //Criação das instacias do editor e assinante
            Publisher remetente = new Publisher();
            Subscriber receptor = new Subscriber();

            //Define o tratamento do evento
            remetente.TrabalhoFeito += receptor.OnTrabalhoFeitoEventHandler;

            //Invoca o método
            remetente.ProcessaUmTrabalho();

            Console.ReadKey();
        }
    }
}
