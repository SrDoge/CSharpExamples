using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacaoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A serialização é o processo de converter um objeto em um fluxo de dados e armazenar na memoria, BD ou arquivos.
            //Salvando o estado atual do objeto para recria-lo quando necessario
            //A desserialização é o processo inverso disso. Permite a criação de um novo objeto com base nos dados armazenados. 
            //Restaurando o objeto salvo

            //SerializacaoString.Method();
            //SerializacaoObj.Method();

            DesserializacaoString.Method();
            DesserializacaoObj.Method();

        }
    }
}
