using System;

namespace operacoesmatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            float num1, num2, Resultado=0;

            Console.WriteLine("Informe o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada: [1 - Adição; 2 - Subtração; 3 - Multiplicação; 4 - Divisão]");
            op = int.Parse(Console.ReadLine());

            if(op==1){
                Resultado = num1 + num2;
                Console.WriteLine("O resultado da adição é: {0:N}", Resultado);
            } else {
                if(op==2){
                    Resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: {0:N}", Resultado);
                } else {
                    if(op==3){
                        Resultado = num1 * num2;
                        Console.WriteLine("O resultado da multiplicação é: {0:N}", Resultado);
                    } else {
                        if(op==4){
                            Resultado = num1 / num2;
                            Console.WriteLine("O resultado da divisão é: {0:N}", Resultado);
                        } else {
                            Console.WriteLine("Operação inválida!");
                        }
                    }
                }
            }
        }
    }
}
