using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializacaoCSharp
{
    class SerializacaoString
    {
        public static void Method()
        {
            string dados = "teste";

            //criação de um arquivo para salvar os dados da string
            FileStream fs = new FileStream("Serializacao.Data", FileMode.Create);

            //objeto do tipo BinaryFormatter para realizar a serialização 
            BinaryFormatter bf = new BinaryFormatter();

            //Objeto bf sendo usado para serializar a string dados no arquivo criado 
            try
            {
                bf.Serialize(fs, dados);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Falha ao serializar, motivo: " + e.Message);
            }
            finally
            {
                //Fecha o arquivo
                fs.Close();
            }

            Console.WriteLine("String - Arquivo Serializado.");
            Console.ReadKey();
        }

    }
}
