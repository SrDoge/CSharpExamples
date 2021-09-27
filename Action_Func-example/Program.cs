using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Func_example
{
    class Program
    {
        static List<Inventario> lista;

        //Expressões lambda é uma função anônima que pode criar um delegate ou tipos de arvore de expressão
        static void Main(string[] args)
        {
            lista = Inventario.CriarLista();

            Console.WriteLine("Chamadas de métodos List e iterando com o Action ForEach\n");

            Console.Write("Digite o custo: ");
            double qtdCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Produtos com o custo menor que o informado");
            EncontrarItensMenorCustoFunc(qtdCusto).ForEach(i => Console.WriteLine($"ID = {i.Id}, " +
                $"Nome = {i.Nome}, Estoque = {i.Estoque}, Preco = {i.Preco} "));
            Console.WriteLine();

            //Chamada de método List e iterando com a instrução foreach, traz o mesmo resultado
            //var listaCusto = EncontrarItensMenorCustoFunc(3.99);
            //foreach (var i in listaCusto)
            //{
            //    Console.WriteLine($"ID = {i.Id}, Estoque = {i.Estoque}, Preco = {i.Preco}");
            //}

            Console.Write("Digite a qtd de estoque: ");
            int qtdEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("Produtos com estoque maior ou igual que o informado");
            EncontrarMaiorEstoque(qtdEstoque).ForEach(i => Console.WriteLine($"ID = {i.Id}, " +
                $"Nome = {i.Nome}, Estoque = {i.Estoque}, Preco = {i.Preco}"));
            Console.WriteLine();

            Console.WriteLine("Digite o ID desejado: ");
            int buscaId = int.Parse(Console.ReadLine());
            EncontrarID(buscaId).ForEach(i => Console.WriteLine($"ID = {i.Id}, " +
                $"Nome = {i.Nome}, Estoque = {i.Estoque}, Preco = {i.Preco}"));
            Console.WriteLine();

            Console.ReadKey();

        }

        public static List<Inventario> EncontrarItensMenorCustoFunc(double custoUnitario) => lista
            .Where(item => item.Preco < custoUnitario)
            .OrderBy(i => i.Preco)
            .ToList<Inventario>();

        public static List<Inventario> EncontrarMaiorEstoque(int estoque) => lista
            .Where(item => item.Estoque >= estoque)
            .OrderBy(i => i.Estoque)
            .ToList<Inventario>();

        public static List<Inventario> EncontrarID(int id) => lista
            .Where(item => item.Id == id)
            .ToList<Inventario>();

    }
}
