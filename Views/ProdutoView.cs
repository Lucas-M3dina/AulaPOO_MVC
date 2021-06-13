using System;
using System.Collections.Generic;
using Exemplo_MVC.Models;

namespace Exemplo_MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto){

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : {item.Preco:C2}");
            }

        }

        public Produto CadastrarProduto(){

            Produto produto = new Produto();

            Console.Write($"Digite um código: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write($"Digite o Preço: ");
            produto.Preco = float.Parse(Console.ReadLine());
            
            return produto;
        }
    }
}