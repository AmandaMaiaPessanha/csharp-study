using System;

namespace csharpStudy.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // Deixa a string toda maiúscula
            var saudacao = "olá".ToUpper();

            // Insere junto a palavra OLA, o valor de World!
            saudacao.Insert(3, " World!");

            //Substitúi a palavra world por mundo.
            saudacao.Replace(" World!", " Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            
            // Toma um erro de instância de objeto
            //Console.WriteLine(valorImportante.Length);
            // Usando a interogação diz que ele só vai acessar esse valor se ele estiver definida
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
