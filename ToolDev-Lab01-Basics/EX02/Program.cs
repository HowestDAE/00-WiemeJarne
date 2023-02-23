using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Lasdt name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Greetings {firstName} {lastName}!");
            
            Console.ReadLine(); //to make the console not close automatically
        }
    }
}
