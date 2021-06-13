using System;
using AulaPOO_ProjetoDeProdutos.Models;
using AulaPOO_ProjetoDeProdutos.Views;
using Exemplo_MVC.Controllers;

namespace AulaPOO_ProjetoDeProdutos.Controllers
{
    public class LoginController
    {
        public bool loop = true;
        Login login = new Login();
        LoginView loginView = new LoginView();
        UsuarioController user = new UsuarioController();
        MarcaController marca = new MarcaController();
        ProdutoController prod = new ProdutoController();

        public void Logar(){
            loginView.LogarView();
            login.AprovandoLogin(user.RetornoUser(), loginView);
        }
        public void Login(){
            do
            {
                switch ((loginView.MenuLogin()))
                {
                    case 1:
                        user.Cadastrar();
                        loop = true;
                        break;
                    case 2:
                        Logar();
                        while (login.logado == true)
                        {
                            if (login.logado != false)
                            {
                                switch (loginView.MenuLogado())
                                {
                                    case "1":
                                        marca.Cadastrar();
                                        break;
                                    case "2":
                                        marca.ListarMarcas();
                                        break;
                                    case "3":
                                        prod.Cadastrar();
                                        break;
                                    case "4":
                                        prod.ListarProdutos();
                                        break;
                                    case "5":
                                        login.Deslogado();
                                        loop = false;
                                        break;
                                    default:
                                        Console.WriteLine($"Opção digitada eh desconhecida");
                                        break;
                                }
                                
                            }
                        }
                        break;
                    default:
                        break;
                }
                
            } while (loop == true);
        }
    }
}