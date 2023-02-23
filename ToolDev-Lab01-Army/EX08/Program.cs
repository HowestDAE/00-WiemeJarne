using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier Foo = new Soldier("Soldier0");
            Soldier Bar = new Soldier("Soldier1");

            Random random = new Random();
            int soldierStartNr = random.Next(0, 2);
            int soldierTurnNr = soldierStartNr;

            while (!Foo.IsDead && !Bar.IsDead)
            {
                if(soldierTurnNr == 0)
                {
                    Foo.ShootAt(Bar);
                    if(Bar.IsDead) Console.WriteLine($"{Foo.Name} wins!");
                    else Console.WriteLine(Bar);

                    soldierTurnNr = 1;
                }
                else if(soldierTurnNr == 1)
                {
                    Bar.ShootAt(Foo);
                    if(Foo.IsDead) Console.WriteLine($"{Bar.Name} wins!");
                    else Console.WriteLine(Foo);

                    soldierTurnNr = 0;
                }
                
                Console.ReadKey(true); //wait for a key press before next turn
            }
        }
    }
}
