using System;

namespace csharpStudy.ClassesEMetodos
{
    class CalculadoraComun
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }
    }


    class MetodosComRetorno
    {
        public static void Executar()
        {

            var calculadoraComun = new CalculadoraComun();

            Console.WriteLine(calculadoraComun.Somar(5, 5));
            
            Console.WriteLine(calculadoraComun.Subtrair(2, 7));

            Console.WriteLine(calculadoraComun.Multiplicar(4, 4));

            Console.WriteLine(calculadoraComun.Divisao(10, 2));
        }
    }
}
