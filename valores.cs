﻿using System;

namespace valores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro valor inteiro:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1>=n2){
                Console.WriteLine("{0}, {1}", n2, n1);
            } else {
                Console.WriteLine("{0}, {1}", n1,n2);
            }
        }
    }
}
