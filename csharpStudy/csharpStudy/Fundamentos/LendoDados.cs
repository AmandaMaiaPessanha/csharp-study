using System;
using System.Globalization;

namespace csharpStudy.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome ? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade ? ");
            // Parse, transformar um texto em uma string
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário ? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}, {idade}, R${salario}");
        }
    }
}
