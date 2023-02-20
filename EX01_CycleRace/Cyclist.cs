using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EX01_CycleRace
{
    internal class Cyclist
    {
        private readonly char[] _WHEELCHARS = {'/', '-', '\\', '|'};

        private uint _WheelState;
        public uint WheelState { 
            get { return _WheelState; }
            set {
                if (_WheelState >= (_WHEELCHARS.Length - 1))
                    _WheelState = 0;
                else
                    _WheelState = value;
                
            }
        }

        private Random _rnd = new Random();

        private int _xPos = 0;
        public int XPos { get; }

        private ConsoleColor _color;
        public ConsoleColor Color { get { return _color; } }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }

        public Cyclist(string name)
        {
            _name = name;
            RandomizeColor();
        }

        public Cyclist(string name, ConsoleColor color)
        {
            _name = name;
            _color = color;
        }

        public void RandomizeColor()
        {
            int amountOfColors = Enum.GetValues(typeof(ConsoleColor)).Length;
            int color = _rnd.Next(0, amountOfColors);

            while ((ConsoleColor)color == ConsoleColor.Black || (ConsoleColor)color == ConsoleColor.White)
            {
                color = _rnd.Next(0, amountOfColors);
            }
            
            _color = (ConsoleColor)color;
        }

        public void Display()
        {
            Console.ForegroundColor = _color;
            Console.WriteLine("   __°".PadLeft(_xPos));
            Console.WriteLine(" _ \\<,_".PadLeft(_xPos));
            Console.WriteLine($"({_WHEELCHARS[_WheelState]})/ ({_WHEELCHARS[_WheelState]})".PadLeft(_xPos));

            DisplayStreet();
        }

        private void DisplayStreet()
        {
            Console.WriteLine(_name.PadRight(Console.WindowWidth, '='));
        }

        public bool Update()
        {
            _xPos += _rnd.Next(1, 5);
            WheelState = _WheelState + 1;
            
            if(_xPos >= (Console.WindowWidth - 9))
                    return true;

            return false;
        }
    }
}
