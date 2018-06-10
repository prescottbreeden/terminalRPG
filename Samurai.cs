namespace Player_project
{
    public class Samurai : Player
    {
        public Samurai(string name) : base(name)
        {
            this.strength = 5;
        }
        public void DeathBlow(Enemy enemy)
        {
            if ((enemy.health/enemy.max_health) < .5)
            {
                enemy.health = 0;
                System.Console.WriteLine("{0} performs special attack 'DEATHBLOW' on {1}", this.name,enemy.name);
            }
            else
            {
                System.Console.WriteLine("Death Blow can only be used on monsters with less than 50% hp, lose your turn.");
            }
        }
        public void Meditate(Player player)
        {
            player.health += 100;
            if (player.health > player.max_health)
                player.health = player.max_health;
            System.Console.WriteLine("{0} has used a special ability 'MEDITATE' and has restored 100 HP", player.name);
        }
    }
}