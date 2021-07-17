using System;

namespace valores2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;

            Console.WriteLine("Quanto você tem para a passagem? R$ [Use , em vez de .]");
            valor = float.Parse(Console.ReadLine());

            if(valor<=10){
                Console.WriteLine("Vá de ônibus!");
            } else {
                if(valor>10 && valor<=50){
                    Console.WriteLine("Vá de táxi!");
                } else {
                    if(valor>50 && valor<=150){
                        Console.WriteLine("Vá de avião!");
                    } else {
                        if(valor>150 && valor<=500){
                            Console.WriteLine("Vá de helicóptero!");
                        } else {
                            if(valor>500){
                                Console.WriteLine("Vá de navio!");
                            }
                        }
                    }
                }
            }
                
    
        }
    }
}
