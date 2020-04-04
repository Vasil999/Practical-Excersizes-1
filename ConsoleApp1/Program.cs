using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var watch = new Stopwatch(); //see which method is faster

            watch.Start();
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("low mark");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("avarage mark");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("good mark");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("excellent mark");
                    break;
                default:
                    Console.WriteLine("invalid mark");
                    break;
            }
            watch.Stop();

            Console.WriteLine(watch.Elapsed);

            watch.Start();
            if (num >= 1 && num <= 4)
            {
                Console.WriteLine("low mark");
            }
            else if (num >=5 && num <= 6)
            {
                Console.WriteLine("avarage mark");

            }
            else if (num >= 7 && num <= 8)
            {
                Console.WriteLine("good mark");

            }
            else if (num >= 9 && num <= 10)
            {
                Console.WriteLine("excellent mark");

            }
            else
            {
                Console.WriteLine("invalid mark");
            }

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }
    }
}
