using System;

namespace mediasalario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;

            Console.WriteLine("Informe o valor do salário: R$");
            salario = float.Parse(Console.ReadLine());
            soma = soma + salario;

            Console.WriteLine("Informe o valor do salário: R$");
            salario = float.Parse(Console.ReadLine());
            soma = soma + salario;

            Console.WriteLine("Informe o valor do salário: R$");
            salario = float.Parse(Console.ReadLine());
            soma = soma + salario;

            Console.WriteLine("Informe o valor do salário: R$");
            salario = float.Parse(Console.ReadLine());
            soma = soma + salario;

            Console.WriteLine("Informe o valor do salário: R$");
            salario = float.Parse(Console.ReadLine());
            soma = soma + salario;

            media = soma / 5;
            Console.WriteLine("O valor médio dos salários é : R${0:N}.", media);
        }
    }
}
