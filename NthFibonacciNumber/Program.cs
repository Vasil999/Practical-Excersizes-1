using System;

namespace NthFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int number = N - 1; //Need to decrement by 1 since we are starting from 0
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            Console.WriteLine("The Nth Fibonaccinumber is " + Fib[number]);
        }
    }
}
