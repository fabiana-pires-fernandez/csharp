using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            float media;

            Console.WriteLine("Informe sua média: ");
            media = float.Parse(Console.ReadLine());

            if(media>=7){
                Console.WriteLine("Você está aprovado!");
            } else {
                Console.WriteLine("Você está reprovado!");
            }
        }
    }
}
