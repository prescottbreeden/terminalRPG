using System;
using System.Collections.Generic;

namespace Player_project
{
    public class Battle
    {
        public static int monster_type_roll;
        public static int number_of_monsters;
        public static int count;
        public static int num_choice = -1;
        public static int experience_points;
        public static Enemy monster;
        public static void BattleInit(Player player)
        {
            Random rand = new Random();
            number_of_monsters = rand.Next(2,5);
            List<Enemy> list_of_monsters = new List<Enemy>();
            for(count = 1; count < number_of_monsters; count++)
            {
                monster_type_roll = rand.Next(1,3);    
                switch(monster_type_roll)
                {
                    case 1:
                        Enemy Spider = new Enemy("Spider" + count); 
                        list_of_monsters.Add(Spider);
                        break;
                    case 2:
                        Enemy Zombie = new Enemy("Zombie" + count); 
                        list_of_monsters.Add(Zombie);
                        break;
                }
            }
            System.Console.WriteLine("Look out!!!");
            System.Threading.Thread.Sleep(3000);
            Spider_Monster();
            for (var idx = 0; idx < list_of_monsters.Count; idx++)
                    {
                        experience_points += list_of_monsters[idx].level * 5;
                    }
            Battle.Fight(list_of_monsters, player);
        }
        public static void Fight(List<Enemy> enemies, Player player)
        {
            while (enemies.Count > 0)
            {
                while (num_choice < 0 || num_choice > enemies.Count-1)
                {
                    System.Console.WriteLine("Choose a Monster to attack:");
                    for (var idx = 0; idx < enemies.Count; idx++)
                    {
                        System.Console.WriteLine($"{idx}. {enemies[idx].name} - Lvl: {enemies[idx].level} - HP: {enemies[idx].health}");
                    }
                    num_choice = Int32.Parse(Console.ReadLine());
                    if (num_choice > enemies.Count-1)
                    {
                        System.Console.WriteLine($"'{num_choice}' was not an available option, please choose again...");
                    }
                } 
                Enemy attack_choice = enemies[num_choice] as Enemy;
                player.Attack(attack_choice);
                // System.Console.WriteLine("Choose an ability: ");
                // if (player is Ninja)

                System.Console.WriteLine($"{player.name} attacked {attack_choice.name} - HP: {attack_choice.health}");
                if (attack_choice.health <= 0)
                {
                    enemies.Remove(attack_choice);
                }
                num_choice = -1;
                System.Console.WriteLine("\n");
                if (enemies.Count > 0)
                {
                    Battle.EnemyAttack(enemies, player);
                }
                else
                {
                    System.Console.WriteLine($"{player.name} defeated the monsters!!");
                    player.LevelUp(experience_points, player);
                }
            }
        }
        
        public static void EnemyAttack(List<Enemy> enemies, Player player)
        {
             for (var idx = 0; idx < enemies.Count; idx++)
                {
                    System.Threading.Thread.Sleep(1000);
                    Random rand = new Random();
                    if (rand.Next(1,5) == 1)
                    {
                        System.Console.WriteLine($"{player.name} evaded!");
                    }
                    else
                    {
                        enemies[idx].Attack(player);
                        System.Console.WriteLine($"{enemies[idx].name} attacked you; you now have {player.health} HP remaining.");
                    }
                }
                if (player.health <= 0)
                {
                    System.Console.WriteLine("You have died...");
                    World.GameOver();
                }
                else
                {
                    System.Console.WriteLine("\n");
                    Battle.Fight(enemies, player);
                }
        }
        public static void Flee()
        {
            Random rand = new Random();

        }
        public static void PreemptiveStrike(List<Enemy> enemies, Player player)
        {
                Random rand = new Random();
                if (rand.Next(1,11)==10)
                {
                    System.Console.WriteLine($"Preemptive Strike!! {player.name} unleashes a hidden demon from within...");
                    for(var i = 0; i < enemies.Count; i++)
                    {

                    player.PreemptiveAttack(enemies[0], player);
                    System.Console.WriteLine($" ... {enemies[i].name} - remaining HP: {enemies[i].health}");
                    if (enemies[i].health <= 0)
                    {
                        enemies.Remove(enemies[i]);
                    }
                    }
                }

                Battle.Fight(enemies, player);
        }
        public static void Spider_Monster()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine(@"                     'you look tasty...'");
            System.Console.WriteLine(@"");
            System.Console.WriteLine(@"                          _ ----- _");
            System.Console.WriteLine(@"                     .-~             ~-.");
            System.Console.WriteLine(@"                   /                     \");
            System.Console.WriteLine(@"        .-- -- -- |                       | -- -- --.");
            System.Console.WriteLine(@"    .-~ / ~~ ~~ ~~ \        O   O        / ~~ ~~ ~~ \ ~-.");
            System.Console.WriteLine(@".-~   /        _ - ~ ~-.             .-~ ~ - _        \   ~-.");
            System.Console.WriteLine(@"    /      /~          /  ~\/---\/~  \          ~\      \");
            System.Console.WriteLine(@"  /       /           /               \           \       \");
            System.Console.WriteLine(@"         /           /                 \           \");
            System.Console.WriteLine(@"        /           /                   \           \");
            System.Console.WriteLine(@"       /           |                     |           \");
            System.Console.WriteLine(@"                   |                     |");
            System.Console.WriteLine(@"                   |                     |");
            System.Console.WriteLine(@"                   |                     |");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
        public static void Zombie_Monster()
        {
            System.Console.WriteLine(@"-----------------------------------");
            System.Console.WriteLine(@"        ________________");
            System.Console.WriteLine(@"       /   ___   ___    \");
            System.Console.WriteLine(@"       |  < 0 > < 0 >   |");
            System.Console.WriteLine(@"       |      /_\       |  Brains!");
            System.Console.WriteLine(@"       |    ________    |");
            System.Console.WriteLine(@"       |   (_\/__\/_)   |");
            System.Console.WriteLine(@"       \________________/");
            System.Console.WriteLine(@"-----------------------------------");
        }
    }
}
