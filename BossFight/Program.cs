using System;

namespace BossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("          Welcome to Boss Fight!");
            Console.WriteLine("   Available commands are fight and rest");

            var game = new Game();

            game.GameLoop();
        }
    }
}
