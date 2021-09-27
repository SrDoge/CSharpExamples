using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AwaitOperator
{
    class Program
    {
        //Permissão para o método Main ser assíncrono, permitindo o uso do operador Await, assim é possivel aguardar a conclusão
        //de uma outra operação assíncrona.
        static async Task Main()
        {
            //Criação da Task<TResult> passando outro método async Task<TResult>
            //Uso da expressão nameof, reproduzindo o nome do método passado entre () no console.
            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(Main)}: Launched downloading.");

            //**O controle volta nesse trecho, o método Main é executado até precisar do resultado do método DownloadDocsMainPageAsync
            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");
        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

            //instanciação de um client do tipo HttpClient, fornecendo a base para enviar requisições e receber respostas HTTP.
            var client = new HttpClient();

            //Operação assíncrona que produz um array de bytes quando finalizada.
            //Operador await suspende o método (DownloadDocsMainPageAsync) INSTANTANEAMENTE até o término da operação, controle volta para o método Main.**
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            //Quando o método GetByteArrayAsync obtem todos os dados e salva na variavel, o restante do método é avaliado,
            //em seguida o restante do método Main é avaliado.
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");

            return content.Length;
        }
    }
}
