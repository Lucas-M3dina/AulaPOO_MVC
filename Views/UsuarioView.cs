using System;
using AulaPOO_ProjetoDeProdutos.Models;

namespace AulaPOO_ProjetoDeProdutos.Views
{
    public class UsuarioView
    {
        
        public Usuario CadastrarUsuario(){

            Usuario user = new Usuario();

            Console.Write($"Digite seu nome: ");
            user.Nome = Console.ReadLine();

            Console.Write($"Digite seu email: ");
            user.Email = Console.ReadLine();

            Console.Write($"Digite uma senha: ");
            user.Senha = Console.ReadLine();
            
            return user;
        }
    }
}