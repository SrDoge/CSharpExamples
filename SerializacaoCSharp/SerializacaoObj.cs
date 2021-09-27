using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializacaoCSharp
{
    class SerializacaoObj
    {
        public static void Method()
        {
            //Criação do arquivo para salvar os dados
            FileStream fs = new FileStream("SerializacaoComplexa.Data", FileMode.Create);

            //Objeto do tipo BinaryFormatter para realizar a serialização 
            BinaryFormatter bf = new BinaryFormatter();

            //Objeto bf sendo usado para serializar os dados (datetime.now) no arquivo criado 
            bf.Serialize(fs, DateTime.Now);
            
            //Fecha o arquivo
            fs.Close();

            Console.WriteLine("Objeto - Arquivo Serializado.");
            Console.ReadKey();
        }
    }
}
