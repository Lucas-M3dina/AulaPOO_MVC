using System.Collections.Generic;
using Exemplo_MVC.Models;
using Exemplo_MVC.Views;

namespace Exemplo_MVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){

            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);

            
        }

        public void Cadastrar(){

            Produto produto = produtoView.CadastrarProduto();

            produto.Inserir( produto );

        }
    }
}