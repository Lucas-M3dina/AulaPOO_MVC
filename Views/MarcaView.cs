using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Models;

namespace AulaPOO_ProjetoDeProdutos.Views
{
    public class MarcaView
    {
        public void Listar(List<Marca> marcas){

            foreach (var item in marcas)
            {
                Console.WriteLine($"\nCódigo : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                
            }

        }

        public Marca CadastrarMarca(){

            Marca marca = new Marca();

            Console.Write($"\nDigite um código");
            marca.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o Nome da Marca: ");
            marca.Nome = Console.ReadLine();

            return marca;
        }
    }
}