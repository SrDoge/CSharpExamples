using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEvent
{
    class Subscriber
    {
        //Tratamento do evento.
        public void OnTrabalhoFeitoEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("O Subscriber/Assinante foi notificado");
        }
    }
}
