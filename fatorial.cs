using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int fatorial = 1;
            for (int n = 1; n <= 5; n++) {
                fatorial*=n;
            }
                     
            Console.WriteLine("5x4x3x2x1= "+fatorial); 
        
        }
    }
}

