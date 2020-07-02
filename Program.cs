using System;
using System.Collections.Generic;

namespace Aula30_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 6;
            p1.Nome = "Guitarra Ibanez ";
            p1.Preco = 6500f;

            p1.Criar(p1);
           

            Produto alterado = new Produto();
            alterado.Codigo = 8;
            alterado.Nome = "Jackson";
            alterado.Preco = 5000f;

            p1.Alterar(alterado);

             p1.Remover("Ibanez");
            
            

            List<Produto> lista = new List<Produto>();
            lista = p1.Ler();

            foreach(Produto item in lista){
                Console.WriteLine($"{item.Preco} - {item.Nome}");
            }
        }
    }
}
