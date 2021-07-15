using System;

namespace decisaosimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade; //declaração da variável idade como inteiro

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine()); //leitura da idade e conversão em inteiro

            if(idade>=18) //teste condicional
            Console.WriteLine("Você tem idade para tirar carteira de habilitação."); 
            //mensagem se condição for verdadeira



        }
    }
}
