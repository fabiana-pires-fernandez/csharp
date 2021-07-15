using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            float tc, tf; //declaração das variáveis de tc e tf

            Console.WriteLine("Informe a temperatura em Graus Celsius: ");

            tc = float.Parse(Console.ReadLine());
            tf = (tc * 1.8f) + 32f; //variável tf recebe a fórmula para seu cálculo.

            Console.WriteLine("A temperatura em Fahrenheit é {0:N}°F.", tf); //impressão em F
        }
    }
}
