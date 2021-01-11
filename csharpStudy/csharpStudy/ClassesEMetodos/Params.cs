using System;
using System.Collections.Generic;
using System.Text;

namespace csharpStudy.ClassesEMetodos
{
    class Params
    {

        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá, {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia", "Amanda", "Aline", "Isabella");
        }
    }
}
