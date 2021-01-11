using System;

namespace csharpStudy.ClassesEMetodos
{
    class Carro
    {
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            // Construtor padrão
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325I";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}. Construtor padrão, construtor vazio.");

            //Definição de um construtor na classe Carro.
            var carro2 = new Carro("Ka", "Frod", 2018);

            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}. " +
                $"Construtor definido na classe Carro, que recebe parâmetros");

            var carro3 = new Carro()
            {

                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}. " +
                $"Construtor padrão passando diretamente os parâmetros.");
        }
    }
}
