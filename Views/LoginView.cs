using System;

namespace AulaPOO_ProjetoDeProdutos.Views
{
    public class LoginView
    {
        public int opcaoMenuPrincipal;
        public string opcaoMenuSecundario;
        public string verificandoEmail;
        public string verificandoSenha;

        public void LogarView(){
            
            string[] verificando = new string[2];

            Console.Write($"Digite seu Email: ");
            verificandoEmail = Console.ReadLine(); 

            Console.Write("Digite sua Senha: ");
            verificandoSenha = Console.ReadLine();

            
        }

        public int MenuLogin(){
            Console.Write($@"
    Menu

[1] Cadastrar Usuario
[2] Fazer Login
    
R: ");
            opcaoMenuPrincipal = int.Parse(Console.ReadLine());
            return opcaoMenuPrincipal;
        }

        public string MenuLogado(){
            Console.Write($@"
=============================================
|                   MENU:                   |
---------------------------------------------
|    [1] - Cadastrar Marcas                 |
|    [2] - Listar as Marcas cadastradas     |
|    [3] - Cadastrar produto                |
|    [4] - Listar produtos cadastrados      |
|    [5] - Deslogar                         |
=============================================
R: ");
            opcaoMenuSecundario = Console.ReadLine();
            return opcaoMenuSecundario;
        }
    }
}