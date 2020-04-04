using System;

namespace SumOfManyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            double tosum = 1, sum = 0;
            
            while(tosum != 0)
            {
                Console.Write($"{i}. number: ");
                tosum = double.Parse(Console.ReadLine());
                sum += tosum;
                i++;
            }

            Console.WriteLine($"The sum of the numbers you have entered is {sum}.");
        }
    }
}
