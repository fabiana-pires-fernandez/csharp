using System;

namespace altobaixo
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;

            Console.WriteLine("Informe a sua altura: [use . e não ,]");
            altura = float.Parse(Console.ReadLine());

            if (altura>=1.80){
                Console.WriteLine("Alto");
            } else {
                Console.WriteLine("Baixo");
            }
        }
    }
}
