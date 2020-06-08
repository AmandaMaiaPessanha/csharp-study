using System;

namespace csharpStudy.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            // usando o const antes de identificar o tipo da variável faz com que ela não seja mais alterada durante o algortmo
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValueInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValueInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor log " + menorValorLong);

            ulong populacaoMundial = 7_680_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
