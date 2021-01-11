using System;

namespace csharpStudy.ClassesEMetodos
{
    class Membros
    {
        // Comportamento = Métodos.
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Amanda";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoFulano = fulano.Apresentar();
            Console.WriteLine("Método apresentar, com string format: " + apresentacaoFulano);
            Console.WriteLine("Tamanho da string acima: " + apresentacaoFulano.Length);
        }
    }
}
