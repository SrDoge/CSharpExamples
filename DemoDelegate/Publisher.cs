using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEvent
{
    class Publisher
    {
        //Criação de um delegate com "NomeDoEvento"+EventHandler
        public delegate void TrabalhoFeitoEventHandler(object sender, EventArgs args);

        //Criação de um evento baseado no delegate
        public event TrabalhoFeitoEventHandler TrabalhoFeito;

        public void ProcessaUmTrabalho()
        {
            Console.WriteLine("Publisher/Editor : Um trabalho foi concluído.");
            //Dispara o evento
            OnTrabalhoFeito();
        }

        //O padrão requer que o método seja definido como protected virtual,
        //O nome precisa coincidir com o nome do evento utilizando o prefixo "On".
        protected virtual void OnTrabalhoFeito()
        {
            if (TrabalhoFeito != null) TrabalhoFeito(this, EventArgs.Empty);
        }
    }
}
