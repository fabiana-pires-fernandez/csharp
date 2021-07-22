using System;

namespace somavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int quantidade, soma;

            Console.WriteLine("Informe quantos número iremos somar: ");
            quantidade = int.Parse(Console.ReadLine());

            numeros = new int[quantidade];
            soma = 0;

            for(int i = 0; i < quantidade; i++) {
                Console.WriteLine("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                soma = soma + numeros[i];
             }
            Console.WriteLine("A soma dos números é {0}.", soma);
        }
    }
}
