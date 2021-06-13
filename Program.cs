using System;
using AulaPOO_ProjetoDeProdutos.Controllers;
using Exemplo_MVC.Controllers;
using Exemplo_MVC.Models;

namespace Exemplo_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginController login = new LoginController();
            login.Login();

        }
    }
}
