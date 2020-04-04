using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, sum;

            Console.Write("First number: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            number2 = double.Parse(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

        }
    }
}
