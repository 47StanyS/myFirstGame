using System;

namespace myFirstGame
{
    enum WeaponTyp
    {
        ROCK = 1, SCISSORS, PAPER
    }
    class mainClass
    {

        public static void Main(string[] args)
        {
            int roundsPlayed = 0;
            int victories = 0;

            Console.WriteLine("Hi, what is your nicname?");
            string nickname = Console.ReadLine();

            Console.WriteLine($"{nickname}, how old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age < 12) 
            {
                Console.WriteLine("The application can be used from 12 years old!");
                Console.WriteLine($"Goodbye {nickname}");
                return;
            } 

            Console.WriteLine("OK!");
            Console.WriteLine($"\nYour stats for this run:");
            Console.WriteLine($"Nic: {nickname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Number of rounds played: {roundsPlayed}");
            Console.WriteLine($"Number of wins: {victories}");

            Random randomGenerator = new Random();

            bool yesNo = true;
            while (yesNo)
            {
                Console.WriteLine("you vona go?\npress 'Yes'or'No' ");
                string choose = Console.ReadLine().ToLower();
                if (choose != "yes")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                for ( int round = 1; round <=3; round++)
                {
                    Console.WriteLine("Choose your weapon type Rock-1, Scissors-2, Paper-3 press number: ");
                    int userChoice =int.Parse(Console.ReadLine());

                    WeaponTyp numWeapon;
                    numWeapon = (WeaponTyp)userChoice;

                    WeaponTyp compWeapon = (WeaponTyp)randomGenerator.Next(1,4);

                    if((userChoice>=1)&& (userChoice <= 3))
                    {
                        Console.WriteLine($"User {nickname} chose {numWeapon}");
                        Console.WriteLine($"Comp chose {compWeapon}");
                    }
                }
            }



        }

    }
}


