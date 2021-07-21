using System;

namespace medianota
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            float n1, n2, n3, media;
            string nome, continua;

            Console.Clear(); //Limpar console
            do {
                Console.WriteLine("Digite o nome do aluno: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a primeira nota: ");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota: ");
                n2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota: ");
                n3 = float.Parse(Console.ReadLine());

                media = (n1 + n2 + n3) / 3;

                Console.WriteLine(nome+", sua média é {0:n}.", media);

                do {
                    if(media>=9) {
                        Console.WriteLine("Você foi APROVADO, sua menção é A!");
                        break;
                    }

                    if(media>=7) {
                        Console.WriteLine("Você foi aprovado, sua menção é B!");
                        break;
                    }
                
                    if(media>=5) {
                        Console.WriteLine("Você foi reprovado, sua menção é C!");
                        break;
                    }
                    
                    else {
                        Console.WriteLine("Você foi reprovado, sua menção é D!");
                        break;
                    }
                } while(true);

                Console.WriteLine("Você quer continuar? [S - Sim ou N - Não].");
                continua = Console.ReadLine();
            } while(continua == "s" || continua == "S");
                
            Console.WriteLine("Fim do programa! :)");
            
        }
    }
}
