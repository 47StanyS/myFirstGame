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
            if (age < 12) 
            {
                Console.WriteLine("The application can be used from 12 years old!");
                Console.WriteLine($"Goodbye {nickname}");
                return;
            } 
           // else Console.WriteLine("The application can be used from 12 years old!");

            Console.WriteLine("OK!");
            Console.WriteLine($"\nYour stats for this run:");
            Console.WriteLine($"Nic: {nickname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Number of rounds played: {roundsPlayed}");
            Console.WriteLine($"Number of wins: {victories}");
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
                //yesNo = choose.ToLower() != "yes" ? true : false;
                Console.WriteLine("OK!");
                Console.WriteLine($"\nYour stats for this run:");
                Console.WriteLine($"Nic: {nickname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Number of rounds played: {roundsPlayed}");
                Console.WriteLine($"Number of wins: {victories}");
            }



        }
        /*private static void YesNo()
        {
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
                //yesNo = choose.ToLower() != "yes" ? true : false;
            }
        }


        /*private static void YesNo()
        {
            bool yesNo = true;
            while (yesNo)
            {
                Console.WriteLine("you vona go? 'Yes' or 'No'");
                yesNo = Console.ReadLine() == "y" ? true : false;
            }
        }*/
    }
}


