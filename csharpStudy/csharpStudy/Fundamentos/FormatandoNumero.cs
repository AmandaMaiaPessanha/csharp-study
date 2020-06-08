using System;
using System.Globalization;

namespace csharpStudy.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            
            // Separando por casa decimal
            Console.WriteLine(valor.ToString("F1"));
            
            // Valor monetário
            Console.WriteLine(valor.ToString("C"));

            // Percentual
            Console.WriteLine(valor.ToString("P"));

            //Quer um número com duas casas decimais, poderia ter usado o F2
            Console.WriteLine(valor.ToString("#.##"));

            // Definindo uma cultura para poder usar um currency específico
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));

            // Conseguir completar dados no resultado final da string
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
