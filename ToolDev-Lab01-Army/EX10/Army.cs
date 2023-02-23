using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    internal class Army
    {
        static private Random random = new Random();
        
        private Soldier[] _soldiers = new Soldier[10];

        public bool AllSoldiersDead
        {
            get
            {
                return _soldiers.Count(soldier => soldier.IsDead) == _soldiers.Length;
            }
        }


        public enum side
        {
            enemy,
            friend
        }

        private readonly side _side;

        public Army(side side_)
        {
            _side = side_;

            _soldiers[0] = new Soldier($"{this}01");
            _soldiers[1] = new Soldier($"{this}02");
            _soldiers[2] = new Soldier($"{this}03");
            _soldiers[3] = new Soldier($"{this}04");
            _soldiers[4] = new Soldier($"{this}05");
            _soldiers[5] = new Soldier($"{this}06");
            _soldiers[6] = new Soldier($"{this}07");
            _soldiers[7] = new Soldier($"{this}08");
            _soldiers[8] = new Soldier($"{this}09");
            _soldiers[9] = new Soldier($"{this}10");
        }

        public override string ToString()
        {
            if (_side == side.enemy)
                return "Friend";

            if (_side == side.friend)
                return "Enemy";

            return "";
        }

        public Soldier GetRandomLivingSoldier()
        {
            Soldier randomLivingSoldier = _soldiers[random.Next(_soldiers.Length)];

            while(randomLivingSoldier.IsDead)
            {
                randomLivingSoldier = _soldiers[random.Next(_soldiers.Length)];
            }

            return randomLivingSoldier;
        }
    }
}
