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

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine($"{memoria}");
            return this;
        }

        public int Resultado()
        {
            return memoria;
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

            var calculadoraCadeia = new CalculadoraCadeia();

            Console.WriteLine("Calculadora Cadeia");
            calculadoraCadeia.Somar(3).Subtrair(3).Multiplicar(3).Dividir(3).Imprimir().Limpar().Imprimir();

            var resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);

        }
    }
}
