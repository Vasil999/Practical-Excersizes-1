using System;

namespace MultiplicateBy2ifOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Type in your number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number % 2 != 0)
            {
                Console.WriteLine($"2 * {number} = {2*number}");
            }
            else
            {
                Console.WriteLine("The number is even! ");
            }
        }
    }
}
