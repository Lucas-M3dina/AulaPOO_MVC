using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Models;
using AulaPOO_ProjetoDeProdutos.Views;

namespace AulaPOO_ProjetoDeProdutos.Controllers
{
    public class UsuarioController
    {
        Usuario user = new Usuario();
        UsuarioView userView = new UsuarioView();

        public void Cadastrar(){
            user.Inserir(userView.CadastrarUsuario());
        }

        public List<Usuario> RetornoUser(){
            List<Usuario> usuarios = user.RetornoListaUsuario();
            return usuarios;
        }
    }
}