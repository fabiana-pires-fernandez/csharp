using System;

namespace circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double pi = 3.14;

            Console.WriteLine("Digite o raio do círculo: [mm]");
            r = double.Parse(Console.ReadLine());

            double circulo = CalculaAreaCirculo(pi, r);
            Console.WriteLine($"Área do círculo: {circulo}");
        }

        static double CalculaAreaCirculo(double pi, double r)
        {
            
            double area = pi * (r*r);
            return area;
        }
        
    }
}
