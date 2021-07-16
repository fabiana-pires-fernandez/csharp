using System;

namespace jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string time1, time2;
            int gols1, gols2;

            Console.WriteLine("Digite o nome do primeiro time: ");
            time1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do segundo time: ");
            time2 = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de gols do " + time1);
            gols1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de gols do time " + time2);
            gols2 = int.Parse(Console.ReadLine());

            if (gols1>gols2) {
                Console.WriteLine("O time " + time1 + " ganhou a partida!");
            }

            if (gols2>gols1) {
                Console.WriteLine("O time " + time2 + " ganhou a partida!");
            }

            if (gols1==gols2) {
                Console.WriteLine("O jogo empatou!");
            }
        }
    }
}
