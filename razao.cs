using System;

namespace razao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, cont=0, razao;

            Console.WriteLine("Informe o primeiro número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            razao = num2 - num;

            while(cont<10){
                Console.WriteLine(" "+num);
                num = num + razao;
                cont++;
            }
        }
    }
}
