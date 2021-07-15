using System;

namespace areat
{
    class Program
    {
        static void Main(string[] args)
        {
            float baset, alturat, areat;
            
            Console.WriteLine("Informe a base do triângulo: (em m)");
            baset = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo: (em m).");
            alturat = float.Parse(Console.ReadLine());

            areat = (baset * alturat) / 2;
            Console.WriteLine("A área do triângulo é {0}m.", areat);

        }
    }
}
