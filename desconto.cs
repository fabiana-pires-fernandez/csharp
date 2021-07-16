using System;

namespace pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            string estado;
            float pedido, desconto=0, total;

            Console.WriteLine("Informe o estado do pedido: (Ex: RJ)");
            estado = Console.ReadLine();

            Console.WriteLine("Informe o valor do pedido: ");
            pedido = float.Parse(Console.ReadLine());

            if(estado=="RJ") {
                if(pedido>=2000)
                    desconto = 30f;
                else   
                    desconto = 15f;
            }
            
            total = pedido - (pedido * desconto/100);
            Console.WriteLine("Valor com descontos: R${0:N}", total);

        }
    }
}
