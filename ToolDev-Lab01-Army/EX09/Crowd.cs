using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    internal class Crowd
    {
        Random _random = new Random();

        Soldier[] _soldiers =
            { 
                new Soldier("Soldier#0"),
                new Soldier("Soldier#1"),
                new Soldier("Soldier#2"),
                new Soldier("Soldier#3"),
                new Soldier("Soldier#4"),
                new Soldier("Soldier#5"),
                new Soldier("Soldier#6"),
                new Soldier("Soldier#7"),
                new Soldier("Soldier#8"),
                new Soldier("Soldier#9")
            };

        public bool OneManLeft
        {
            get
            {
                return _soldiers.Count(soldier => !soldier.IsDead) == 1;
            }
        }

        public Soldier Fight()
        {
            while (!OneManLeft)
            {
                int randomSoldier1 = GenerateRandomNr();
                int randomSoldier2 = GenerateRandomNr();

                while (_soldiers[randomSoldier1].IsDead) //dead soldier can't shoot
                    randomSoldier1 = GenerateRandomNr();

                while (_soldiers[randomSoldier2].IsDead) //don't shoot at dead soldier
                    randomSoldier2 = GenerateRandomNr();

                _soldiers[randomSoldier1].ShootAt(_soldiers[randomSoldier2]);

                Console.WriteLine(_soldiers[randomSoldier2]);
                Console.ReadKey(true); //wait for a key press before next turn
            }

            foreach(Soldier soldier in _soldiers)
            { 
                if(!soldier.IsDead)
                {
                    Console.WriteLine($"Soldier {soldier.Name} wins");
                    return soldier;
                }
            }

            return null;
        }

        private int GenerateRandomNr()
        {
            return _random.Next(0, _soldiers.Length);
        }
    }
}
