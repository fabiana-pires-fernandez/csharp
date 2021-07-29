using System;

namespace somar
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = Somar(10, 7); // atribuindo a variável soma o retorno de Somar
            double media1 = soma / 2.0;
            Console.WriteLine(media1); // imprime 8.5

            // usando direto na expressão o retorno de Somar

            double media2 = Somar(6, 9) / 2.0;
            Console.WriteLine(media2); // imprime 7.5
        }

        static int Somar(int num1, int num2)
        {
            int soma;
            soma = num1 + num2;
            return soma;
        }
            
    }
}