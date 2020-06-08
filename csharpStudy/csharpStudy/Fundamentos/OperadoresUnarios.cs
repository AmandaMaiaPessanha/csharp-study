using System;

namespace csharpStudy.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar ()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            // Como estou trabalhando com um valor negativo, passando o sinal de menos, o valor final passa a ser verdadeiro
            Console.WriteLine(-valorNegativo);

            // Estou realizando uma negação lógica
            Console.WriteLine(!booleano);

            // Operador pós-fixado
            numero1++;
            Console.WriteLine(numero1);

            // Operador pré-fixado
            --numero1;
            Console.WriteLine(numero1);

            // Número2 será removido antes de ser feita a comparação = 2 é igual a 2 
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
