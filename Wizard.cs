using System;
using System.Collections.Generic;

namespace Player_project
{
    public class Wizard : Player
    {
        public Wizard(string name) : base(name)
        {
            this.intellect = 25;
        }
        public void Heal(Player player)
        {
            player.health += player.intellect*2;
            if (player.health > player.max_health)
                player.health = player.max_health;
            System.Console.WriteLine("{0} has used a special ability 'HEAL' and now has {1} health", player.name, player.health);
        }
        public void Fireball(Enemy enemy)
        {
            Random rand = new Random();
            enemy.health -= rand.Next(20,50);
        }
    }
}