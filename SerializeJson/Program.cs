using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SerializeJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa();
            p.nome = "João";
            p.idade = 43;

            var stream1 = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Pessoa));

            ser.WriteObject(stream1, p);

            stream1.Position = 0;
            var p2 = (Pessoa)ser.ReadObject(stream1);
            //Console.Write("JSON form of person object: ");
            Console.WriteLine($"Deserialized back, got name = {p2.nome}, age = {p2.idade}");
        }


        [DataContract]
        internal class Pessoa
        {
            [DataMember]
            internal string nome;

            [DataMember]
            internal int idade;
        }
    }
}
