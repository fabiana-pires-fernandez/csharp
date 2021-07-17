using System;

namespace maioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, idade;

            Console.WriteLine("Digite o ano de nascimento: [Ex: 1990]");
            anoNascimento = int.Parse(Console.ReadLine());
            idade = DateTime.Now.Year - anoNascimento; //ano atual - ano informado

            if(idade >= 18) {
                Console.WriteLine("Maior de idade");
            } else {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
