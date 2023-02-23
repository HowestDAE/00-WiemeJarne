using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    internal class Battle
    {
        private Random _random = new Random();

        private Army _enemy = new Army(Army.side.enemy);
        private Army _friendly = new Army(Army.side.friend);

        public void Fight()
        {
            while(!_enemy.AllSoldiersDead && !_friendly.AllSoldiersDead)
            {
                Soldier randomEnemy = _enemy.GetRandomLivingSoldier();
                Soldier randomFriendly = _friendly.GetRandomLivingSoldier();

                int randomNr = GenerateRandomNr(0, 1);

                if(randomNr == 0)
                {
                    randomEnemy.ShootAt(randomFriendly);
                    randomFriendly.ShootAt(randomEnemy);
                }
                else if(randomNr == 1)
                {
                    randomFriendly.ShootAt(randomEnemy);
                    randomEnemy.ShootAt(randomFriendly);
                }

                Console.WriteLine($"{randomFriendly} versus {randomEnemy}");

                if(randomEnemy.IsDead)
                {
                    Console.WriteLine($"{randomEnemy} died at {DateTime.Now}");
                }

                if(randomFriendly.IsDead)
                {
                    Console.WriteLine($"{randomFriendly} died at {DateTime.Now}");
                }

                System.Threading.Thread.Sleep(1000);
            }

            if(_enemy.AllSoldiersDead)
            {
                Console.WriteLine("Friend wins!");
            }
            else
            {
                Console.WriteLine("Enemy wins!");
            }
        }

        private int GenerateRandomNr(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
