using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double i=5, n=5, n2=-1;

            while(n2!=5) {
                n2 = Math.Pow(n, i);
                Console.WriteLine(" {0} ", n2);
                if(n2<500)
                    Console.WriteLine(" X \n");
                else
                    Console.WriteLine(" Y \n");
                
                i--;
                n++;

                if(i==0)
                    n2=5;
            }
        }
    }
}
