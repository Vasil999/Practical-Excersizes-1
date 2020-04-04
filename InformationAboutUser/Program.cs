using System;

namespace InformationAboutUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, phonenumber, age;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your email: ");
            email = Console.ReadLine();

            Console.WriteLine("Enter your phonenumber: ");
            phonenumber = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();

            Console.WriteLine($"The user {name} is {age} old. His phonenumber is {phonenumber} and his email is {email}");
        }
    }
}
