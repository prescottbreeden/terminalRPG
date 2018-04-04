using System;
using System.Collections.Generic;

namespace Player_project
{
    public class Player
    {
        public string name;
        public int level;
        public int exp;
        public int steps_taken;
        public int health;
        public int max_health;
        public int strength;
        public int dexterity;
        public int intellect;
        public Player(string name)
        {
            this.name = name;
            this.strength = 3;
            this.intellect = 3;
            this.dexterity = 3;
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
            if (player.exp >= 50)
            {
                player.level++;
                player.exp = 0;
                BoostStats(player);
            }
            else
                World.Options(player);
        }
        public void BoostStats(Player player)
        {
            player.strength += 1;
            player.dexterity += 1;
            player.intellect += 1;
            player.health += 10;
            player.max_health += 10;
            System.Console.WriteLine($"{player.name} gained a level and is now {player.level}!");
            System.Threading.Thread.Sleep(1500);
            System.Console.WriteLine("\n");
            World.Options(player);
        }
    }
}