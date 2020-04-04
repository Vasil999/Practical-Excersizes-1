using System;

namespace NumbersFrom1ToNwhichAreDivisibleBy3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
