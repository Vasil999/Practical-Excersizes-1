using System;

namespace N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            
            int NFactorial = 1;
            
            for(int i = 1; i<=N; i++)
            {
                NFactorial *= i;
            }

            Console.WriteLine("N! = " + NFactorial);
            Console.WriteLine();
        }
    }
}
