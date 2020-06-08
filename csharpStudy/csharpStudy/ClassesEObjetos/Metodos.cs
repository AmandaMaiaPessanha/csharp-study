namespace csharpStudy.ClassesEObjetos
{
    class Metodos
    {
        // Metodos que tem entrada e saida;
        public int Somar(int number1, int number2)
        {
            int soma = number1 + number2;
            return soma;
        }

        // Metodos que tem entrada, mas não tem retorno;
        public void Metodo(string a, int b)
        {
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
