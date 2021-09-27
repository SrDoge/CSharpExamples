using System;
using System.Collections.Generic;
using System.Text;

namespace Action_Func_example
{
    class Inventario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public static List<Inventario> CriarLista()
        {
            List<Inventario> listaInventario = new List<Inventario>();

            listaInventario.Add(new Inventario { Id = 1, Nome = "ProdutoA", Estoque = 5, Preco = 9.99 });
            listaInventario.Add(new Inventario { Id = 2, Nome = "ProdutoB", Estoque = 6, Preco = 6.99 });
            listaInventario.Add(new Inventario { Id = 3, Nome = "ProdutoC", Estoque = 7, Preco = 3.09 });
            listaInventario.Add(new Inventario { Id = 4, Nome = "ProdutoD", Estoque = 2, Preco = 4.59 });
            listaInventario.Add(new Inventario { Id = 5, Nome = "ProdutoE", Estoque = 1, Preco = 2.79 });
            listaInventario.Add(new Inventario { Id = 6, Nome = "ProdutoF", Estoque = 4, Preco = 1.09 });

            return listaInventario;
        }
    }
}
