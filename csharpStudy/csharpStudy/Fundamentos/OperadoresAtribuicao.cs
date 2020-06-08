using System;

namespace csharpStudy.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void  Executar()
        {
            var num1 = 3;

            // Atribuição de substituição
            num1 = 7;

            // Atribuição aditiva, é acrescentar ao valor obtido
            num1 += 10; // num1 = num1 + 10; === 7 = 7 + 10

            // Atribuição negativa, é diminuir do valor obtido
            num1 -= 3; // num1 = num1 - 3; === 17 = 17 - 3

            // Atribuição multiplicativa, é multiplicar ao valor obtido
            num1 *= 5; // num1 = num1 * 5; === 14 = 14 * 5

            // Atribuição divisiva, é dividir ao valor obtido
            num1 /= 2;  // num1 = num1 / 2; === 70 = 70 / 2 

            Console.WriteLine(num1);

            // Atribuição de um valor literal
            int a = 1;

            // Atribuição entre variáveis
            int b = a;

            // Atribuição implícita, operador unário de adição
            a++; // a = a + 1;

            // Atribuição implícita, operador unário de subtração
            b--; //b = b - 1

            Console.WriteLine($"{a} {b}");

            // Não se preocupe com código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            // Atribuição por referência
            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
