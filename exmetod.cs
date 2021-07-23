using System;

namespace exmetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
           string nome = Console.ReadLine();
           Console.WriteLine($"OLá {nome}");
           BoasVindas();
        }

        static void BoasVindas()
        {
            if(DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 18) {
                Console.WriteLine("Tenha um bom dia!");
            } else {
                Console.WriteLine("Tenha uma boa noite!");
            }
        }
    }
}
