using System;

namespace myFirstGame
{
    enum WeaponTyp
    {
        ROCK = 1, SCISSORS, PAPER
    }
    class mainClass
    {
        static Random randomGenerator = new Random();
        public static void Main(string[] args)
        {

            int roundsPlayed = 0;
            int victories = 0;
            int wins = 0;
            int lose = 0;

            RockScissorsPaper();

            Console.WriteLine("Hi, what is your name?\nOr nicname?");
            string nickname = Console.ReadLine();


            Console.WriteLine($"{nickname}? Ahahahah, how old are you? {nickname}.");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            if (age < 12) 
            {
                Console.WriteLine("Oh, you need to grow up.\nThe application can be used from 12 years old!");
                Console.WriteLine($"Goodbye {nickname}");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Ouuu, you’re NOT as YOUNG as you seem at first glance.\nHere, take this book, it will come in handy on your adventure.");
            Stats(nickname, age, roundsPlayed, victories);

            bool yesNo = true;
            while (yesNo)
            {
                Console.WriteLine("_____________________________________________________________");
                Console.WriteLine("you vona go?\npress 'Yes'or'No' ");
                string choose = Console.ReadLine().ToLower();
                Console.WriteLine("_____________________________________________________________");
                if (choose != "yes")
                {
                    Console.WriteLine($"Farewell, dear, {nickname},just RETURN the BOOK I gave you, and go on your way in good health \n'{nickname}' AHAHHAH what's your name AHAHHA\noh i can't :P");
                    break;
                }
                for ( int round = 1; round <=3; round++)
                {
                    ArtWeapon();

                    Console.WriteLine("Choose your weapon type Rock-1, Scissors-2, Paper-3 press number: ");
                    int userChoice =int.Parse(Console.ReadLine());

                    WeaponTyp numWeapon;
                    numWeapon = (WeaponTyp)userChoice;
                    Console.WriteLine($"User {nickname} chose {numWeapon}"); 

                    WeaponTyp compWeapon = (WeaponTyp)randomGenerator.Next(1,4);
                    Console.WriteLine($"Comp chose {compWeapon}");

                    if(numWeapon == compWeapon)
                    {
                        Console.WriteLine("It`s a tie");
                        Console.WriteLine("_____________________________________________________________");
                    }
                    else if((numWeapon == WeaponTyp.ROCK && compWeapon == WeaponTyp.SCISSORS) ||
                            (numWeapon == WeaponTyp.SCISSORS && compWeapon == WeaponTyp.PAPER) ||
                            (numWeapon == WeaponTyp.PAPER && compWeapon == WeaponTyp.ROCK))
                    {
                        Console.WriteLine("You WIN!");
                        victories++;
                        wins++;
                        Queen();
                        Console.WriteLine("_____________________________________________________________");
                    }
                    else
                    {
                        Console.WriteLine("you lose");
                        lose++;
                        Death();
                        Console.WriteLine("_____________________________________________________________");
                    }
                    roundsPlayed++;
                }

                if(wins >= 2)
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("I knew YOU were CAPABLE of something!");
                    AwardVictory();
                    Console.WriteLine("*********************************************");
                }
                else 
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Baaad, VERY bad!!!");
                    TryBetter();
                    Console.WriteLine("*********************************************");
                }
                Stats(nickname, age, roundsPlayed, victories);
            }
  


        }


        private static void Stats(string nickname, int age, int roundsPlayed, int victories)
        {
            Console.WriteLine("    __________________   __________________");
            Console.WriteLine(".-/|      USER        \\ /      Rock        |\\-.");
            Console.WriteLine("||||    STATISTSCS     |     Scissors      ||||");
            Console.WriteLine("||||                   |       Paper       ||||");
            Console.WriteLine("||||                   |                   ||||");
            Console.WriteLine($"||||    NICNAME ->        {nickname}             ||||");
            Console.WriteLine("||||                   |                   ||||");
            Console.WriteLine($"||||    AGE ->            {age}               ||||");
            Console.WriteLine("||||                   |                   ||||");
            Console.WriteLine($"||||    ROUNDS ->         {roundsPlayed}                ||||");
            Console.WriteLine("||||                   |                   ||||");
            Console.WriteLine($"||||    VICTORIES ->      {victories}                ||||");
            Console.WriteLine("||||__________________ | __________________||||");
            Console.WriteLine("||/===================\\|/===================\\||");
            Console.WriteLine("`--------------------~___~-------------------''");
        }


        private static void AwardVictory()
        {
            string[] sentenceOne =
            {
                "Congratulations, master of strategy and fortune, your victory in this ancient game is a true work of art!",
                "Like a great warrior who defeats dragons, you have conquered the arena of rock, paper, and scissors!",
                "Your wisdom in choice has surpassed the enchantments of the ancients, leading you to a glorious victory!",
                "May your victory be recorded in the annals as a legend of one who masters the secret of rock, paper, and scissors!",
                "You have proven to be a true wizard of battle, manipulating the elements to your advantage!"
            };
            Console.WriteLine(sentenceOne[randomGenerator.Next(sentenceOne.Length)]);
        }


        private static void TryBetter()
        {
            string[] sentenceTwo =
            {
                "May your will be as firm as rock, swift as scissors, and unexpected as paper!",
                "Hold fast, warrior! Your decisions lead to victory in the grand battle of elements!",
                "Trust your intuition, master of elemental forces, and you shall find the path to triumph!",
                "Your fate is already written, like the legendary duel between dragon and fairy - march forward with courage!",
                "With each choice, you weave your destiny, like an ancient weaver - may your patterns be eternal!"
            };
            Console.WriteLine(sentenceTwo[randomGenerator.Next(sentenceTwo.Length)]);


        }
        private static void RockScissorsPaper()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine(" _____     *      _               _    *         *       ");
            Console.WriteLine("|  __ \\          | |             (_)                       ");
            Console.WriteLine("| |__) |___   ___| | __  ___  ___ _ ___ ___  ___  _ __ ___ ");
            Console.WriteLine("|  _  // _ \\ / __| |/ / / __|/ __| / __/ __|/ _ \\| '__/ __|");
            Console.WriteLine("| | \\ \\ (_) | (__|   <  \\__ \\ (__| \\__ \\__ \\ (_) | |  \\__ \\");
            Console.WriteLine("|_|__\\_\\___/ \\___|_|__\\ ____/\\___|_|___/___/\\___/|_|  |___/");
            Console.WriteLine(" _ __   __ _ _ __   ___ _ __                               ");
            Console.WriteLine("| '_ \\ / _` | '_ \\ / _ \\ '__|                             ");
            Console.WriteLine("| |_) | (_| | |_) |  __/ |         *          *            ");
            Console.WriteLine("| .__/ \\__,_| .__/ \\___|_|                           *      ");
            Console.WriteLine("| |         | |                     *           *         ");
            Console.WriteLine("|_|         |_|       *                                 *   ");
            Console.WriteLine("============================================================");
        }
        private static void PaperArt()
        {
            Console.WriteLine(" __________ ");
            Console.WriteLine("()_________) ");
            Console.WriteLine(" \\ ~~~~~~~~ \\");
            Console.WriteLine("  \\ ~~~~~~   \\");
            Console.WriteLine("   \\__________\\");
            Console.WriteLine("   ()__________)");
        }
        private static void ScissorsArt()
        {
            Console.WriteLine("   ^");
            Console.WriteLine("  |.|");
            Console.WriteLine("  |||");
            Console.WriteLine("  |||");
            Console.WriteLine("  |||");
            Console.WriteLine("  |||");
            Console.WriteLine("__|||");
            Console.WriteLine("`----.`");
            Console.WriteLine("  ||  ))");
            Console.WriteLine("  |'-',");
            Console.WriteLine("   '-'");

        }

        private static void ArtWeapon()
        {
            Console.WriteLine("      _____                           ^                            ___________            ");
            Console.WriteLine("   .-\"; ;  \"-.                       |.|    M S                   ()__________)                 ");
            Console.WriteLine("  /  ;        \\                      |||    A C                    \\  ~~~~~~~~ \\             ");
            Console.WriteLine(" |  ; VERY   , |                     |||    G I                     \\   PAPER   \\          ");
            Console.WriteLine(" | ;  MAGIC    |                     |||    I S                      \\___________\\           ");
            Console.WriteLine(" | ;  ROCK     |                     |||    C S                       \\___________\\             ");
            Console.WriteLine(" | !           |                   __|||      O                       ()___________)           ");
            Console.WriteLine(" |_____________|                   `----.`    R                                      ");
            Console.WriteLine("                                     ||  ))   S                              3              ");
            Console.WriteLine("       1                             |'-',");
            Console.WriteLine("                                      '-'");
            Console.WriteLine("                                      2                 ");
        }
        private static void Death()
        {
            Console.WriteLine("      ______");
            Console.WriteLine("   .-\"      \"-.");
            Console.WriteLine("  /            \\   HA!");
            Console.WriteLine(" |              |");
            Console.WriteLine(" |,  .-.  .-.  ,|     HA!");
            Console.WriteLine(" | )(__/  \\__)( |  HA! ");
            Console.WriteLine(" |/     /\\     \\|  ");
            Console.WriteLine(" (_     ^^     _)     HA!");
            Console.WriteLine("  \\__|IIIIII|__/  HA!");
            Console.WriteLine("      (DEATH)");
            Console.WriteLine("   |-\\IIIIII/-|");
            Console.WriteLine("   \\          /");
            Console.WriteLine("    `--------` ");
        }

        private static void Queen()
        {
            Console.WriteLine("   *      o       *");  
            Console.WriteLine("       o^/|\\^o        *NICE*");
            Console.WriteLine(" *  o_^|\\/*\\/|^_o   *  ");
            Console.WriteLine("   o\\*`'.\\|/.'`*/o   NICE   ");
            Console.WriteLine("     \\\\\\\\\\|/////  *  ");
            Console.WriteLine("     {><><@><><}       *NICE   ");
            Console.WriteLine("     `\"\"\"\"\"\"\"\"\"`");
        }


        /*Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");*/
    }
}


