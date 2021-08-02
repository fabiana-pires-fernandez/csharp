using System;

namespace bancario
{

    public class Conta
    {
        public int numero;
        public int digitoVerificador;
        public double saldo;
        public string titular;
        public bool RealizarSaque(double valor)
        {
              if(saldo > valor) 
              {
                saldo = saldo - valor;
                return true;
             }
             else {
                return false; // saldo insuficiente
             }
        }

        public void RealizarDeposito(double valor)
        {
            if(valor > 0)
            {
                saldo = saldo + valor;
            }
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBancaria = new Conta();
            string comando;
            double valor;

            Console.Write("Digite seu nome: ");
            contaBancaria.titular = Console.ReadLine();

            contaBancaria.numero = 1234;
            contaBancaria.digitoVerificador = 1;

            do {
                Console.Write("Digite a operação [d-depósito; s-saque; x-sair] ");
                comando = Console.ReadLine();

                switch(comando) {
                    case "d":

                        Console.Write("Digite o valor a depositar: ");
                        valor = double.Parse(Console.ReadLine());

                        contaBancaria.RealizarDeposito(valor);
                        Console.WriteLine("Deposito realizado com sucesso!");
                        break;
                    
                    case "s":

                        Console.Write("Digite o valor de saque: ");
                        valor = double.Parse(Console.ReadLine());

                        if(contaBancaria.RealizarSaque(valor) == false) {
                            Console.WriteLine("Saldo insuficiente!");
                        } else {
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        break;

                    case "x":

                        Console.Write("Encerrando a aplicação, volte sempre " + contaBancaria.titular + "!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while(comando != "x");
        }
    }
}
