using System;

namespace myFirstGame
{
    class mainClass
    {
        static int roundsPlayed = 0;
        static int victories = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hi, what is your nicname?");
            string nickname = Console.ReadLine();
            Console.WriteLine($"{nickname}, how old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age > 12) 
            {
                Console.WriteLine("OK!");
                Console.WriteLine($"\nYour stats for this run:");
                Console.WriteLine($"Nic: {nickname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Number of rounds played: {roundsPlayed}");
                Console.WriteLine($"Number of wins: {victories}");
            } 
            else Console.WriteLine("The application can be used from 12 years old!");

        }
    }
}


