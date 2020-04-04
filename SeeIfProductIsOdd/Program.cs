using System;

namespace SeeIfProductIsOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your five numbers!");
            int counterPositiveNumbers = 0;

            for (int i = 0; i<=4; i++)
            {
                Console.Write($"{i + 1}. number: ");
                if (double.Parse(Console.ReadLine()) >= 0)
                {
                    counterPositiveNumbers++;
                }
                else
                {
                    continue;
                }
            }

            if (counterPositiveNumbers % 2 == 0)
            {
                Console.WriteLine("The product is negative");
            }
            else
            {
                Console.WriteLine("The product is positive");
            }
        }
    }
}
