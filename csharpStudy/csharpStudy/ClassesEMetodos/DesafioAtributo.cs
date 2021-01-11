using System;

namespace csharpStudy.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            //Acessar variável 'a' dentro do método exeutar! Sem mexer na linha 7.


            // Foi necessário criar uma instância de DesafioAtributo, pois a variável 'a' é um elemento da instância.
            DesafioAtributo desafioAtributo = new DesafioAtributo();

            // Assim conseguimos imprimir no console o resultado.
            Console.WriteLine(desafioAtributo.a);
        }
    }
}
