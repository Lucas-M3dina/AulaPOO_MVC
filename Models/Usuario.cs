using System;
using System.Collections.Generic;
using System.IO;

namespace AulaPOO_ProjetoDeProdutos.Models
{
    public class Usuario
    {

        public string Nome { get; set; }

        public string Email { get; set; }    

        public string Senha {get; set;}

        private const string PATH = "Database/Usuario.csv";

        public Usuario(){

            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Usuario> RetornoListaUsuario(){
            
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Usuario user = new Usuario();

                user.Nome = atributos[0];
                user.Email = atributos[1];
                user.Senha = atributos[2];
                

                usuarios.Add(user);
            }

            return usuarios;

        }

        public void Inserir(Usuario user){

            string[] linhas = {PrepararLinhasCSV(user)};

            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Usuario user){

            return $"{user.Nome};{user.Email};{user.Senha}";
        }
    }
}