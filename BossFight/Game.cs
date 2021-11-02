using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    class Game
    {
        public bool IsFighting;
        public GameCharacters Hero { get; private set; }
        public GameCharacters Boss { get; private set; }

        public Game()
        {
            IsFighting = true;
            Hero = new GameCharacters("Hero",20, 100, 40);
            Boss = new GameCharacters("Boss",30, 400, 10);
        }

        public void GameLoop()
        {
            while (IsFighting)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("Enter command: ");
                var input = Console.ReadLine();
                if (input == "fight")
                {
                    Hero.Fight(Boss);
                }
                if (input == "rest")
                {
                    Hero.Recharge();
                }

                if (Boss.Health < 0)
                {
                    Console.WriteLine("The Hero Wins!");
                    break;
                }
                Boss.Fight(Hero, true);
                if (Hero.Health < 0)
                {
                    Console.WriteLine("Who would have guessed, Hero is dead!");
                    break;
                }
            }
        }
    }
}
