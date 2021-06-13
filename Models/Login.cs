using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Controllers;
using AulaPOO_ProjetoDeProdutos.Views;

namespace AulaPOO_ProjetoDeProdutos.Models
{
    public class Login
    {
        public bool logado = false;
        public bool loop = false;

        public bool Logado(){
            logado = true;
            return logado;
        }

        public bool Deslogado(){
            logado = false;
            return logado;
        }

        public void AprovandoLogin(List<Usuario> usuarios , LoginView loginView){
             
            Usuario userEncontrado = usuarios.Find(x => x.Email == loginView.verificandoEmail  && x.Senha == loginView.verificandoSenha);

            if (userEncontrado != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nUsuário logado com sucesso!");
                Console.ForegroundColor = ConsoleColor.White;
                Logado();
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nAlgo deu errado. Verifique as informações digitadas!");
                Console.ForegroundColor = ConsoleColor.White;
                Deslogado();
            }
        }

        
    }
}