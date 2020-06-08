using System;

namespace csharpStudy.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            // Operação de soma
            double total = preco + imposto;
            // Operação de subtração junto com a muliplicação
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);


            // Cálculo do IMC
            double peso = 65.5;
            double altura = 1.65;

            // Divisão
            double IMC = peso / (altura * altura);
            // Math.Pow = usando para potências
            double IMC2 = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC usando (altura * altura) é {IMC}.");
            Console.WriteLine($"O IMC usando (Math.Pow(altura, 2)) é {IMC}.");

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            // Estamos usando módulos
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
