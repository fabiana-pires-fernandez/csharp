using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contatos = new string[5];

            Console.WriteLine("Digite o primeiro nome: ");
            contatos[0] = Console.ReadLine();

            Console.WriteLine("Digite o segundo nome: ");
            contatos[1] = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nome: ");
            contatos[2] = Console.ReadLine();

            Console.WriteLine("Digite o quarto nome: ");
            contatos[3] = Console.ReadLine();

            Console.WriteLine("Digite o quinto nome: ");
            contatos[4] = Console.ReadLine();

            for(int i = 0; i < contatos.Length; i++) {
                Console.WriteLine("Contato " + (i + 1) + ": " + contatos[i]);
            }

        }
    }
}
