using System;
using System.Collections.Generic;

namespace Player_project
{
    public class Travel
    {
        public static void Walk(Player player)
        {
            player.steps_taken += 10;
            Random rand = new Random();
            int outcome = rand.Next(1,3);
            switch(outcome)
            {
                case 1:
                    Battle.BattleInit(player);
                    break;
                case 2:
                    System.Console.WriteLine("You move along the path.");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("The tower gets closer.");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("\n");
                    World.Options(player);
                    break;
            }
            
        }
    }
}