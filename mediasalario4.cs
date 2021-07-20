using System;

namespace mediasalario4
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;
            int cont=0;

            do {
                Console.WriteLine("Informe o valor do salário: ");
                salario = float.Parse(Console.ReadLine());

                soma = soma + salario; // Acumulador
                cont = cont + 1; // Contador
            } 
            
            while(cont<5);
            media = soma / cont;
            Console.WriteLine("O valor médio dos salários é : R${0:N}.", media);
        }
    }
}
