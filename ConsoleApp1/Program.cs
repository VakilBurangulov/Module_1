using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.Write("Enter your birthday: ");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Your birthday is {birthday}");
        }
    }
}
