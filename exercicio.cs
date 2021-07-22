using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] celular = {"Xiaomi", "LG", "Samsung"};

            foreach(string i in celular) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fim!");
        }
    }
}
