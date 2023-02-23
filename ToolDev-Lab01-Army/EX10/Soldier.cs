using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    internal class Soldier
    {
        static private Random _rnd = new Random();

        private int _health = 10;
        public int Health
        {
            get
            {
                if(IsDead) return 0;

                return _health;
            }
        }

        private string _name;
        public string Name { get { return _name; } }

        public bool IsDead { get; private set; }

        public Soldier(string name)
        {
            _name = name;
        }

        private void Hit(int damage)
        {
            _health -= damage;

            if(_health <= 0)
            {
                IsDead = true;
            }
        }

        public void ShootAt(Soldier other)
        {
            other.Hit(_rnd.Next(1, 4));
        }

        public override string ToString()
        {
            return $"{_name} has health {Health}";
        }
    }
}
