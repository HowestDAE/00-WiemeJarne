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
            Console.WriteLine("Enter the names of the cyclists to start.... (seperate the names with comma's no spaces");
            string namesInputed = Console.ReadLine();
            List<Cyclist> cyclists = new List<Cyclist>{ };
            while(namesInputed.IndexOf(',') != -1) //loop over the namesInputed until no comma's are found
            {
                cyclists.Add(new Cyclist(namesInputed.Substring(0, namesInputed.IndexOf(','))));
                namesInputed = namesInputed.Remove(0, cyclists.Last().Name.Length + 1);
            }
            
            cyclists.Add(new Cyclist(namesInputed)); //add the last name
            
            while(true)
            {
                Console.SetCursorPosition(0, 3);
            
                foreach (Cyclist cyclist in cyclists)
                {
                    if(cyclist.Update())
                    {
                        goto WinnerFound; //when the current cyclist has won stop the race
                    }

                    cyclist.Display();
                }
            
                Thread.Sleep(100);
            }

        WinnerFound:
            int winnerIndex = -1;
            for (int i = 1; i < cyclists.Count; ++i)
            {
                if (cyclists[i - 1].XPos < cyclists[i].XPos)
                {
                    winnerIndex = i;
                }
            }

            if(winnerIndex >= 0)
            {
                Console.ForegroundColor = cyclists[winnerIndex].Color;
                Console.WriteLine("".PadLeft(30 + cyclists[winnerIndex].Name.Length, '*'));
                Console.WriteLine($"*  AND THE WINNER IS.... {cyclists[winnerIndex].Name}");
                Console.WriteLine("".PadLeft(30 + cyclists[winnerIndex].Name.Length, '*'));
            }

            //with 2 cyclists
            //Console.Write("Enter the name of the first cyclist: ");
            //string nameCyclist1 = Console.ReadLine();
            //Cyclist cyclist1 = new Cyclist(nameCyclist1);
            //
            //Console.Write("Enter the name of the second cyclist: ");
            //string nameCyclist2 = Console.ReadLine();
            //Cyclist cyclist2 = new Cyclist(nameCyclist2);
            //
            //Console.WriteLine($"Ready, {nameCyclist1} and {nameCyclist2}? Let the race begin!!!");
            //
            //Console.Read();
            //
            //while(cyclist1.Color == cyclist2.Color)
            //{
            //    cyclist1.RandomizeColor();
            //}
            //
            //while(!cyclist1.Update() && !cyclist2.Update())
            //{
            //    Console.SetCursorPosition(0, 3);
            //
            //    cyclist1.Display();
            //    cyclist2.Display();
            //
            //    Thread.Sleep(100);
            //}
            //
            //if (cyclist1.XPos > cyclist2.XPos)
            //{
            //    Console.ForegroundColor = cyclist1.Color;
            //    Console.WriteLine("".PadLeft(30 + cyclist1.Name.Length, '*'));
            //    Console.WriteLine($"*  AND THE WINNER IS.... {cyclist1.Name}");
            //    Console.WriteLine("".PadLeft(30 + cyclist1.Name.Length, '*'));
            //}
            //else
            //{
            //    Console.ForegroundColor = cyclist2.Color;
            //    Console.WriteLine("".PadLeft(30 + cyclist2.Name.Length, '*'));
            //    Console.WriteLine($"*  AND THE WINNER IS.... {cyclist2.Name}!!  *");
            //    Console.WriteLine("".PadLeft(30 + cyclist2.Name.Length, '*'));
            //}

            // //if this is not here the console closes automaticaly
            Console.Read();
            Console.Read();
        }  
    }
}
