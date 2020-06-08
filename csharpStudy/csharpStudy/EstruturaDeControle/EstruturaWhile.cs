using System;

namespace csharpStudy.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasAtuais = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas.", tentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                } else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }
        }
    }
}
