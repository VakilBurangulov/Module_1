using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var User = FillOutTheCarrtage();
            ConsoleWriteUser(User);
        }

        static (string Name, string LastName, int Age, bool IsPet, int MountPets, string[] Pets, int MountFavFlowers, string[] FavFlowers) FillOutTheCarrtage()
        {
            (string Name, string LastName, int Age, bool IsPet, int MountPets, string[] Pets, int MountFavFlowers, string[] FavFlowers) User;
            User = (null, null, 0, false, 0, null, 0, null);
            Console.WriteLine("Введи своё имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введи свою фамилию");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Введи свой возраст");
            User.Age = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; )
            {
                Console.WriteLine("Есть ли у тебя питомец Да/Нет");
                switch (Console.ReadLine())
                {
                    case "Да":
                        User.IsPet = true; i = 1; break;
                    case "Нет":
                        User.IsPet = false; i = 1; break;
                }
            }
            switch (User.IsPet)
            {
                case true:
                    Console.WriteLine("Сколько у тебя питомцев");
                    User.MountPets = int.Parse(Console.ReadLine()); break;
                default:
                    User.MountPets = 0; break;
            }
            if (User.MountPets > 0)
                User.Pets = Pets(User.MountPets);
            Console.WriteLine("Сколько у тебя любимых цветов");
            User.MountFavFlowers = int.Parse(Console.ReadLine());
            if (User.MountFavFlowers > 0)
                User.FavFlowers = FavFlowers(User.MountFavFlowers);
            Correct(ref User);
            return User;
        }

        static string[] Pets(int Mount)
        {
            string[] Pets = new string[Mount];
            for (int i = 0; i < Mount; i++)
            {
                Console.WriteLine("Введи кличку {0}го питомца", i + 1);
                Pets[i] = Console.ReadLine();
            }
            return Pets;
        }

        static string[] FavFlowers(int Mount)
        {
            string[] Flowers = new string[Mount];
            for (int i = 0; i < Mount; i++)
            {
                Console.WriteLine("Введи название {0}го цветка", i + 1);
                Flowers[i] = Console.ReadLine();
            }
            return Flowers;
        }

        static void Correct(ref(string Name, string LastName, int Age, bool IsPet, int MountPets, string[] Pets, int MountFavFlowers, string[] FavFlowers) User)
        {
            bool correct = true;
            if (User.IsPet & User.MountPets <= 0)
            {
                Console.WriteLine("Пожалуйста введи корректное количество своих питомцев");
                User.MountPets = int.Parse(Console.ReadLine());
                User.Pets = Pets(User.MountPets);
                correct = false;
            }
            if (User.MountFavFlowers <= 0)
            {
                Console.WriteLine("Пожалуйста введи корректное количество любимых цветов");
                User.MountFavFlowers = int.Parse(Console.ReadLine());
                User.FavFlowers = FavFlowers(User.MountFavFlowers);
                correct = false;
            }
            if (User.Age <= 0)
            {
                Console.WriteLine("Пожалуйста введи корректный возраст");
                User.Age = int.Parse(Console.ReadLine());
                correct = false;
            }
            if (!correct) 
                Correct(ref User);
            
        }

        static void ConsoleWriteUser((string Name, string LastName, int Age, bool IsPet, int MountPets, string[] Pets, int MountFavFlowers, string[] FavFlowers) User)
        {
            Console.WriteLine("Тебя зовут {0}, твоя фамилия {1} и  тебе {2} лет", User.Name, User.LastName, User.Age);
            if (User.IsPet)
            {
                if (User.MountPets == 1)
                {
                    Console.WriteLine("У тебя один питомец его зовут {0}", User.Pets[0]);
                }

                else 
                {
                    Console.WriteLine("У тебя {0} питомцев, их зовут:", User.MountPets);
                    foreach (var i in User.Pets) 
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (User.MountFavFlowers == 1)
            {
                Console.WriteLine("У тебя один любимый цветок - это {0}", User.FavFlowers[0]);
            }

            else
            {
                Console.WriteLine("У тебя {0} любимых цветков, их названия:", User.MountFavFlowers);
                foreach(var i in User.FavFlowers)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
