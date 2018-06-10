using System;
namespace Player_project
{
    public class Enemy
    {
        public string name { get; set; } 
        public int level {get; set; }
        public int health {get; set; }
        public int max_health {get; set; }
        public int strength {get; set; }
        public int dexterity {get; set; }
        public int intellect {get; set; }
        public Enemy(string name, Player player)
        {
            this.name = name;
            this.level = 1 * player.level;
            this.strength = 1 * player.level;
            this.intellect = 1 * player.level;
            this.dexterity = 1 * player.level;
            this.health = 40 + (10 * player.level);
            this.max_health = 40 + (10 * player.level);
        }
        public Enemy(string name, int health, int strength,int dexterity, int intellect)
        {
            this.health = health;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intellect = intellect;
        }
        public void Attack(Player player)
        {
            player.health -= this.strength * 5;
        }    

        public void SpecialAttack(Player player)
        {
            System.Console.WriteLine("special attack wasn't overwritten");
        }
    }
}