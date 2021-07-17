using System;

namespace sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("Qual é a cor [1 - Verde; 2 - Amarelo; 3 - Vermelho]?");
            op = int.Parse(Console.ReadLine());

            switch(op) {

                case 1:
                    Console.WriteLine("Siga em frente!");
                    break;

                case 2:
                    Console.WriteLine("Atenção!");
                    break;
                
                case 3:
                    Console.WriteLine("Pare!");
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

        }
    }
}
