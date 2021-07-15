using System;

namespace operadorlogico
{
    class Program
    {
        static void Main(string[] args)
        {
            float media, frequencia;
            Console.WriteLine("Informe sua media: ");

            media = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua frequência: ");
            frequencia = float.Parse(Console.ReadLine());

            if(media>=7 && frequencia>=75) {
                Console.WriteLine("Você está aprovado!");
            }
        }
    }
}
