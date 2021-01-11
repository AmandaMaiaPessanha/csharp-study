using System;

namespace csharpStudy.ClassesEMetodos
{
    public class Pessoa
    {
        // Propriedades em PascalCase. Os tipos que ficam em cor azul são do tipo nullable, no caso tem valor null como padrão.
        public string Nome { get; set; }

        // Propriedades em PascalCase. . Os tipos que ficam em cor azul são do tipo nullable, no caso tem valor 0 como padrão.
        public int Idade { get; set; }

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
