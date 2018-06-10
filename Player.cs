using System;
using System.Collections.Generic;

namespace Player_project
{
    public class Player
    {
        public string name { get; set; }
        public int level { get; set; }
        public int exp { get; set; }
        public int steps_taken { get; set; }
        public int health { get; set; }
        public int max_health { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intellect { get; set; }
        public Player(string name)
        {
            this.name = name;
            this.strength = 2;
            this.intellect = 2;
            this.dexterity = 2;
            this.health = 100;
            this.max_health = 100;
            this.exp = 0;
            this.level = 1;
            this.steps_taken = 0;
        }
        public void Attack(Enemy enemy)
        {
            enemy.health -= this.strength * 5;
        } 
        public void PreemptiveAttack(Enemy enemy, Player player)
        {
            enemy.health -= player.dexterity*10;
            System.Console.WriteLine("{0} performs special sneakAttack", player.name);
        }
        public void LevelUp(int experience, Player player)
        {
            player.exp += experience;
            if (player.exp >= player.level * 30)
            {
                player.level++;
                player.exp = 0;
                BoostStats(player);
            }
        }
        public void BoostStats(Player player)
        {
            player.strength += 2;
            player.dexterity += 2;
            player.intellect += 2;
            player.health += 15;
            player.max_health += 15;
            System.Console.WriteLine($"{player.name} gained a level and is now {player.level}!");
            System.Threading.Thread.Sleep(1500);
            System.Console.WriteLine("\n");
        }
    }
}