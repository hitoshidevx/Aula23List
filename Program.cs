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

            //Mostrar produto com forseach
            foreach(Produto x in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Celular: {x.Nome}\n Preço: R${x.Preco}\n Código: {x.Codigo}\n");
                Console.ResetColor();
            }

            List<Cartao> cartao = new List<Cartao>();

            cartao.Add(new Cartao("Gabriel", 329832212, "VISA", 07, 279));
            cartao.Add(new Cartao("Hitoshi", 128129112, "MASTERCARD", 03, 438));
            cartao.Add(new Cartao("Furone", 1762716311, "ELO", 04, 382));
            cartao.Add(new Cartao("Yokogawa", 032939272, "DINNERSCLUB", 11, 214));
            cartao.Add(new Cartao("Hideki", 26313981, "SOROCRED", 10, 235));

            foreach(Cartao x in cartao)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Titular: {x.Titular}\n Número: {x.Numero}\n Bandeira: {x.Bandeira}\n Vencimento: {x.Vencimento}\n CVV: {x.Cvv}\n");
                Console.ResetColor();
            }

        }
    }
}
