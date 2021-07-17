using System;

namespace aovivo1a
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            DateTime dataNascimento;
            DateTime hoje = DateTime.Today;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento: [ex: dd/mm/aaaa]");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            idade = hoje.Year - dataNascimento.Year;
            Console.WriteLine("Olá " + nome + ", você nasceu em " + dataNascimento.Day + "/" + dataNascimento.Month + "/" + dataNascimento.Year + ".");
            Console.WriteLine(nome +", você tem {0} anos.", idade);
        }
    }
}
