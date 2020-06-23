using System;
using System.Collections.Generic;

namespace Aula23List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Criei a lista.
            List<Produto> produtos = new List<Produto>();

            //Adicionei os produtos através de instâncias dos métodos construtores.
            produtos.Add(new Produto(2, "Xiaomi", 1499.7f));
            produtos.Add(new Produto(4, "Samsung", 1999.9f));
            produtos.Add(new Produto(7, "LG", 1784.9f));
            produtos.Add(new Produto(1, "iPhone X", 7999.9f));

            //Ou através de instâncias básicas e suas atribuições.
            Produto iPhone = new Produto();
            iPhone.Codigo = 3;
            iPhone.Nome = "Iphone 7";
            iPhone.Preco = 2499.9f;

            produtos.Add(iPhone);



        }
    }
}
