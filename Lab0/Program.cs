using Lab0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Jarne");
            Hero hero2 = new Hero("player2", "Jarne", 2);
            Console.WriteLine(hero.MyNemisis); //get
            hero.MyNemisis = "my nemisis"; //set
            Console.WriteLine(hero.MyNemisis); //get

            Console.ReadLine();
        }
    }
}
