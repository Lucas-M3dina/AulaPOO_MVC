using AulaPOO_ProjetoDeProdutos.Models;
using AulaPOO_ProjetoDeProdutos.Views;
using Exemplo_MVC.Views;

namespace AulaPOO_ProjetoDeProdutos.Controllers
{
    public class MarcaController
    {
        Marca marca = new Marca();
        MarcaView marcaView = new MarcaView();

        public void ListarMarcas(){
            marcaView.Listar(marca.Ler());
        }

        public void Cadastrar(){
            marca.Inserir(marcaView.CadastrarMarca());
        }
    }
}