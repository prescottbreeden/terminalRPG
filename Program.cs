using System;

namespace Player_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.GameTitle();
            Player player = GameInit.CreateCharacter();
            Storyline.Intro();
            World.Options(player);
            
        }
    }
}
