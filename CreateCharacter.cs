using System;

namespace Player_project
{
    public class GameInit
    {
        public static Player Player = null;
        public static Player CreateCharacter()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("1. Create a character");
            System.Console.WriteLine("2. Quit");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1": 
                    System.Console.WriteLine("Choose a Class:");
                    System.Console.WriteLine("1. Ninja");
                    System.Console.WriteLine("2. Samurai");
                    System.Console.WriteLine("3. Wizard");
                    break;
                case "2":
                    System.Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    break;
            }
            choice = Console.ReadLine();
            System.Console.WriteLine("Enter a name:");
            string PlayerName = Console.ReadLine();
            
            if (choice == "1")
            {
                Ninja ninja = new Ninja(PlayerName);
                System.Console.WriteLine("Welcome Ninja {0}...", PlayerName);
                Player = ninja;
            }
            if (choice == "2")
            {
                Samurai samurai = new Samurai(PlayerName);
                System.Console.WriteLine("Welcome Samurai {0}...", PlayerName);
                Player = samurai;
            }
            if (choice == "3")
            {
                Wizard wizard = new Wizard(PlayerName);
                System.Console.WriteLine("Welcome Wizard {0}...", PlayerName);
                Player = wizard;
            }
            System.Console.WriteLine("Game is initializing... Please wait.");
            System.Threading.Thread.Sleep(5000);
            return Player;
        }
    }
}