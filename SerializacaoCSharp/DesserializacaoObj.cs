using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializacaoCSharp
{
    class DesserializacaoObj
    {
        public static void Method()
        {
            FileStream fs = new FileStream(@"C:\dados\SerializacaoComplexa.Data", FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();
            _ = new DateTime();

            DateTime pt = (DateTime)bf.Deserialize(fs);

            fs.Close();

            Console.WriteLine("Arquivo (Obj) desserializado. \n" + "Dia: " + pt.DayOfWeek + ", Hora: " + pt.TimeOfDay.ToString());
            Console.ReadKey();
        }
    }
}
