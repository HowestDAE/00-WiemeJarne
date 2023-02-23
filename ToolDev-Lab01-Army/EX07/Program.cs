using EX07.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier("soldier");

            while(!soldier.IsDead)
            {
                soldier.ShootAt(soldier);
                Console.WriteLine(soldier);
            }
            
            Console.ReadLine();
        }
    }
}
