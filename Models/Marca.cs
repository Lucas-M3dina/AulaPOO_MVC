using System.Collections.Generic;
using System.IO;

namespace AulaPOO_ProjetoDeProdutos.Models
{
    public class Marca
    {
         public int Codigo { get; set; }

        public string Nome { get; set; }  

        private const string PATH = "Database/Marca.csv";

        public Marca(){

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

        public List<Marca> Ler(){
            
            List<Marca> listaMarcas = new List<Marca>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Marca marca = new Marca();

                marca.Codigo = int.Parse(atributos[0]);
                marca.Nome = atributos[1];

                listaMarcas.Add(marca);
            }

            return listaMarcas;

        }

        public void Inserir(Marca marca){

            string[] linhas = {PrepararLinhasCSV(marca)};

            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Marca marca){

            return $"{marca.Codigo};{marca.Nome}";
        }
    }
}