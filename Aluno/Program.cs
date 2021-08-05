using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaAluno lista = new ListaAluno();
            string resposta = "s";
            do {   
                Aluno aluno = new Aluno();

                Console.WriteLine("Informe o nome do aluno: ");
                aluno.nome = Console.ReadLine();
               
                Console.WriteLine("Informe sua idade: ");
                aluno.idade = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota do aluno: ");
                aluno.nota = double.Parse(Console.ReadLine());

                lista.adicionar(aluno);

                Console.WriteLine("Deseja inserir outro aluno? [s/n]");
                resposta = Console.ReadLine();

                if(resposta == "n")
                {
                    Console.WriteLine(lista.totalizar());
                }

            } while (resposta == "s");
        }
    }
}
