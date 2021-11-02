using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    class GameCharacters
    {
        public int Strength { get; private set; }
        public int Health { get; private set; }
        public int Stamina { get; private set; }

        public string Name { get; private set; }

        public GameCharacters(string name, int strength, int health, int stamina)
        {
            Strength = strength;
            Health = health;
            Stamina = stamina;
            Name = name;
        }
        public void Fight(GameCharacters target, bool isBoss = false)
        {
            if (Stamina < 10)
            {
                Recharge();
                return;
            }

            if (isBoss)
            {
                Random rng = new Random();
                Strength = rng.Next(1, 31);
      
            }
            target.Health -= Strength;
            Console.WriteLine($"{Name} attacked {target.Name} and did {Strength} damage!");
            Console.WriteLine($"{target.Name} now has health {target.Health} left!");
        }

        public void Recharge()
        {
            Stamina += 10;
            Console.WriteLine($"{Name} has recharged! And now has {Stamina} stamina" );
        }
    }
}
