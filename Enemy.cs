using System;
namespace Player_project
{
    public class Enemy
    {
        public string name;
        public int level {get; set; }
        public int health {get; set; }
        public int max_health {get; set; }
        public int strength {get; set; }
        public int dexterity {get; set; }
        public int intellect {get; set; }
        public Enemy(string name)
        {
            this.name = name;
            this.level = 1;
            this.strength = 1;
            this.intellect = 1;
            this.dexterity = 1;
            this.health = 40;
            this.max_health = 40;
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
    }
}