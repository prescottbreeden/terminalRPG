namespace Player_project
{
    public class Ninja : Player
    {
        public string[] abilities { get; set; } 
        public Ninja(string name) : base(name)
        {
            this.dexterity = 5;
            this.abilities = new string[] {"Attack","Steal","RunAway"};
        }
        public static void Steal(Enemy enemy, Player player)
        {
            enemy.health -= player.strength*10;
            player.health += 10;
            if (player.health > player.max_health)
                player.health = player.max_health;
            System.Console.WriteLine("{0} performs special attack 'STEAL' and recovers 10hp", player.name);
        }
        public static void RunAway(Player player)
        {
            player.health -= 15;
            if (player.health <= 0)
                {
                    System.Console.WriteLine("{0} has died attempting to flee", player.name);
                }
            System.Console.WriteLine("{0} has used a special ability 'RUN AWAY' and can no longer be attacked", player.name);
        }
    }
}