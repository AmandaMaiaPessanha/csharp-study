using System;
using System.Collections.Generic;
using System.Text;

namespace csharpStudy.ClassesEMetodos
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {
                
        }


        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2 , 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            // Neste cenário todos os produtos terão o desconto de 10%, por se tratar de uma propriedade estática.
            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto produto 1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto produto 2: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto produto 1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto produto 2: {0}", produto2.CalcularDesconto());
        }
    }
}
