using System;

namespace csharpStudy.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            // Usando o simbolo do maior
            Console.WriteLine("Nota inválida? Maior que 10 (dez) {0}", nota > 10.0);

            // Usando o simbolo do menor
            Console.WriteLine("Nota inválida? Menor que 0 (zero) {0}", nota < 0.0);

            // Usando o símbolo de igualdade
            Console.WriteLine("Perfeito? {0}", nota == 10.0);

            // Usando o símbolo de diferente
            Console.WriteLine("Tem como melhor? {0}", nota != 10.0);

            // Usando o símbolo de maior ou igual
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);

            // Usando o símbolo de menor
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);

            // Usando o símbolo de menor ou igual
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
