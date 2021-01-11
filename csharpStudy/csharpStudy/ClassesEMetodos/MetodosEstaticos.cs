using System;

namespace csharpStudy.ClassesEMetodos
{
    class CalculadoraEstatica
    {

        //Método de instância, só pode ser acessível se criar uma instância da class.
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Método de classe ou Método estático, é possível acessar sem criar uma instância.
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            // Método estático.
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado criado po um método estático: {0}", resultado);

            //Criando uma instância para acessar o método Somar.
            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine("Resultado criando por um método com instância: " + calculadoraEstatica.Somar(2, 2));

        }
    }
}
