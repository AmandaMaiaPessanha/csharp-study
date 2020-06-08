using System;

namespace csharpStudy.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouOTrabalho1 = true;
            var executouOTrabalho2 = false;

            // Operador lógico and, operador binário
            bool comprouTV50 = executouOTrabalho1 && executouOTrabalho2;
            Console.WriteLine("Comprou a TV de 50? {0}", comprouTV50);


            // Operador lógico or, operador binário
            var comprouOSorvete = executouOTrabalho1 || executouOTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouOSorvete);

            // Operador lógico xor (ou exclusivo), operador binário
            var comprouTV32 = executouOTrabalho1 ^ executouOTrabalho2;
            Console.WriteLine("Comprou a TV  de 32? {0}", comprouTV32);

            // Operador lógico de negação, operador unário. Se for falso passa ser verdadeiro, se for verdadeiro passa a ser falso
            Console.WriteLine("Mais saudável? {0}", !comprouOSorvete);
        }
    }
}
