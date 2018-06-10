using System;

namespace Player_project
{
    public class World
    {
        public static void Options(Player player)
        {
            if (player.steps_taken < 200)
            {
                System.Console.WriteLine(".......................................");
                System.Console.WriteLine(".          Choose an option:          .");
                System.Console.WriteLine(". 1. Build a fire and rest            .");
                System.Console.WriteLine(". 2. No time to rest; must keep moving.");
                System.Console.WriteLine(". 3. Exit Game                        .");
                System.Console.WriteLine(".......................................");
                System.Console.WriteLine(">");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1": 
                        BuildFire(player);
                        break;
                    case "2":
                        Travel.Walk(player);
                        break;
                    case "3":
                        System.Console.WriteLine("Thanks for playing!");
                        Environment.Exit(0);
                        break;
                    default:
                        Options(player);
                        break;
                }
            }
            else
            {
                System.Console.WriteLine(".......................................");
                System.Console.WriteLine(".          Choose an option:          .");
                System.Console.WriteLine(". 1. Build a fire and rest            .");
                System.Console.WriteLine(". 2. No time to rest; must keep moving.");
                System.Console.WriteLine(". 3. Enter the tower                  .");
                System.Console.WriteLine(". 4. Exit Game                        .");
                System.Console.WriteLine(".......................................");
                System.Console.WriteLine(">");
                string choice = Console.ReadLine();
                switch(choice)
                    {
                        case "1": 
                            BuildFire(player);
                            break;
                        case "2":
                            Travel.Walk(player);
                            break;
                        case "3":
                            GameVictory(player);
                            break;
                        case "4":
                            System.Console.WriteLine("Thanks for playing!");
                            Environment.Exit(0);
                            break;
                        default:
                            Options(player);
                            break;
                    }
            }
        }
        public static void BuildFire(Player player)
        {
            System.Console.WriteLine("The fire warms you.");
            System.Threading.Thread.Sleep(1500);
            System.Console.WriteLine("The night feels calmer.");
            System.Threading.Thread.Sleep(1500);
            System.Console.WriteLine("You are rested.");
            player.health = player.max_health;
            System.Console.WriteLine("\n");
            System.Threading.Thread.Sleep(1000);
            Options(player);
        }
        public static void GameOver()
        {
            System.Console.WriteLine("You have fallen in battle.");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("(Queue sad music)");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("Game Over.");
            Environment.Exit(0);
        }
        public static void GameVictory(Player player)
        {
            System.Console.WriteLine($"{player.name} has entered the tower and saved the princess!");
            System.Console.WriteLine("Thanks for playing!");

        }
    }
}