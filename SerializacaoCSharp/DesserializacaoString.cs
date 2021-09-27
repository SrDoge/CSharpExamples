using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializacaoCSharp
{
    class DesserializacaoString
    {
        public static void Method()
        {
            //Abrir o arquivo com base na string path passado no parametro do metodo
            FileStream fs = new FileStream(@"C:\dados\Serializacao.Data", FileMode.Open);

            //objeto do tipo BinaryFormatter para realizar a desserialização 
            BinaryFormatter bf = new BinaryFormatter();

            string dados = (string)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("Arquivo (String) desserializado. \n" + dados);
            Console.ReadKey();
        }
    }
}
