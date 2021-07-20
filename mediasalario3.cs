using System;

namespace mediasalario3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;
            int cont=0;

            while(cont<5) {
                Console.WriteLine("Informe o valor de salário: ");
                salario = float.Parse(Console.ReadLine());

                soma = soma + salario; // Acumulador
                cont = cont + 1; // Contador
            }

            media = soma / cont;
            Console.WriteLine("O valor médio dos salários é R${0:N} reais.", media);
        }
    }
}
