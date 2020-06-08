using System;

namespace csharpStudy.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Concatenar
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Interpolação usando chaves ele interpreta pela ordem das variáveis passadas
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            // Interpolação usando dolar é variável
            Console.WriteLine($"A marca {marca} é legal");

            // Interpolação também serve para números
            Console.WriteLine($"1 + 1 = {1 + 1} !");
        }
    }
}
