namespace Player_project
{
    public class Spider : Enemy
    {
        public Spider(string name, Player player) : base(name, player)
        {
            this.dexterity = 1;
        }
        public void SpecialAttack(object obj)
        {
            if (obj is Player)
            {
                Player enemy = obj as Player;
                enemy.health -= this.strength*8;
                System.Console.WriteLine("{0} performs special attack 'WEB' and attacks twice", this.name);
                System.Console.WriteLine("{0} has {1} health remaining", enemy.name, enemy.health);
                if (this.health <= 0)
                {
                    System.Console.WriteLine("{0} has died in battle", this.name);
                }
                if (enemy.health <= 0)
                {
                    System.Console.WriteLine("{0} has died in battle", enemy.name);         
                }
            }
        }
    }
}