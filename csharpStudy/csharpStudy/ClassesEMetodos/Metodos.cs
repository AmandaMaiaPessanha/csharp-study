using System;

namespace csharpStudy.ClassesEMetodos
{
    class Metodos
    {
        // Metodos que tem entrada e saida;
        public int Somar(int number1, int number2)
        {
            Console.WriteLine("Método com entrada e saída");
            number1 = 10;
            number2 = 20;
            int soma = number1 + number2;
            return soma;
        }

        // Metodos que tem entrada, mas não tem retorno;
        public void Metodo(string a)
        {
            Console.WriteLine("Método que possui entrada, mas não temos saída.");
            //Não precisa que esse método tenha um retorno, mas caso queira que em algum if ele tenha um retorno porderia ser feito.
            if (a.Contains("Aprender"))
            {
                return;
            } else
            {
                return;
            }
        }

        //Metodos que não tem entrada, mas retorna algo;
        public bool Metodo()
        {
            Console.WriteLine("Método sem entrada, mas possui retorno.");
            string c = "Aprender";
            if (c.Contains("der"))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
