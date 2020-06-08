using System;

namespace csharpStudy.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão implícita de um valor double para inteiro
            // Usando dessa maneira não temos a possibilidade de perda de informação
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversão errada de um valor double para inteiro
            //double nota = 9.7;
            //int notaTruncada = nota;
            // Para que seja realizada essa conversão será preciso ser feito de maneira explícita com cast
            // Usando cast temos a possibilidade de perda de informação
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada (usando cast): {0}",quebrado);

            
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            // Usando o parse do tipo inteiro
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade informada: {0}" , idadeInteiro);

            // Usando o convert
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            //TryParse significa que ele vai tentar fazer o Parse
            // Out, é usado nesse caso para convertar a palavra e jogue dentro da variável
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);


            Console.Write("Digite o segundo número: ");
            //TryParse significa que ele vai tentar fazer o Parse
            // Out, é usado nesse caso para convertar a palavra e jogue dentro da variável
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);











        }
    }
}
