using System;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3; double max = 0, aver = 0, min = 0;

            Console.WriteLine("Enter your three numbers.");

            Console.Write("number 1: "); number1 = double.Parse(Console.ReadLine());
            Console.Write("number 2: "); number2 = double.Parse(Console.ReadLine());
            Console.Write("number 3: "); number3 = double.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number2)
            {
                max = number1;

                if (number2 > number3)
                {
                    aver = number2;
                    min = number3;
                }
                else
                {
                    aver = number3;
                    min = number2;
                }
            }
            else if (number2 > number1 && number2 > number3)
            {
                max = number2;

                if (number1 > number3)
                {
                    aver = number1;
                    min = number3;
                }
                else
                {
                    aver = number3;
                    min = number1;
                }
            }
            else if (number3 > number1 && number3 > number2)
            {
                max = number3;

                if (number1 > number2)
                {
                    aver = number1;
                    min = number2;
                }
                else
                {
                    aver = number2;
                    min = number1;
                }
            }

            Console.WriteLine($"{min} {aver} {max}");
            Console.WriteLine($"{min} {aver} {max}");
        }
    }
}
