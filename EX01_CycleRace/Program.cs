using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EX01_CycleRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the first cyclist: ");
            string nameCyclist1 = Console.ReadLine();
            Cyclist cyclist1 = new Cyclist(nameCyclist1);

            Console.Write("Enter the name of the second cyclist: ");
            string nameCyclist2 = Console.ReadLine();
            Cyclist cyclist2 = new Cyclist(nameCyclist2);

            Console.WriteLine($"Ready, {nameCyclist1} and {nameCyclist2}? Let the race begin!!!");

            Console.Read();
            
            while(cyclist1.Color == cyclist2.Color)
            {
                cyclist1.RandomizeColor();
            }

            while(!cyclist1.Update() && !cyclist2.Update())
            {
                Console.SetCursorPosition(0, 3);

                cyclist1.Display();
                cyclist2.Display();

                Thread.Sleep(100);
            }

            if (cyclist1.XPos > cyclist2.XPos)
            {
                Console.ForegroundColor = cyclist1.Color;
                Console.WriteLine("".PadLeft(30 + cyclist1.Name.Length, '*'));
                Console.WriteLine($"*  AND THE WINNER IS.... {cyclist1.Name}");
                Console.WriteLine("".PadLeft(30 + cyclist1.Name.Length, '*'));
            }
            else
            {
                Console.ForegroundColor = cyclist2.Color;
                Console.WriteLine("".PadLeft(30 + cyclist2.Name.Length, '*'));
                Console.WriteLine($"*  AND THE WINNER IS.... {cyclist2.Name}!!  *");
                Console.WriteLine("".PadLeft(30 + cyclist2.Name.Length, '*'));
            }
            

            Console.Read();
            Console.Read();
        }
    }
}
