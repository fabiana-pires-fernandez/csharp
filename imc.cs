using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            double[] imc;
            int quantidade;
            double peso, altura;
            string situacao = "";
           
            Console.WriteLine("Digite a quantidade de pacientes: ");
            quantidade = int.Parse(Console.ReadLine());

            imc = new double[quantidade];
            nome = new string[quantidade];

            for(int i = 0; i< quantidade; i++) {

                Console.WriteLine("Digite o nome do paciente: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite o peso do paciente: ");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura do paciente: ");
                altura = double.Parse(Console.ReadLine());

                imc[i] =  peso / (altura * altura);
            }

            Console.Clear();

            for(int i = 0; i< quantidade; i++) { 
                
                if(imc[i] < 20){
                    situacao = "abaixo do peso.";
                } else {
                    if(imc[i] >= 20 && imc[i] <= 25) {
                         situacao = "com peso normal.";
                    } else {
                        if(imc[i] > 25) {
                             situacao = "acima do peso.";
                        }
                    }
                }
                Console.WriteLine("Paciente {0} tem IMC {1} e está {2}", nome[i], imc[i], situacao);   
            }
        }
    }
}
