using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool isPlaying = true;
            int amountOfGuesses = 0;
            while(isPlaying)
            {
                amountOfGuesses = 0;
                Console.WriteLine("Guesss a number betwee 0 and 9");

                const int min = 0;
                const int max = 9;
                int randomInt = GenerateRandomInt(min, max, random);
                int guess = min - 1;

                while(guess != randomInt)
                {
                    ++amountOfGuesses;

                    Console.Write("Your guess: ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess != randomInt)
                    {
                        
                        Console.WriteLine("Incorrect");
                    }
                }

                Console.WriteLine($"Correct in {amountOfGuesses} guesses!");

                Console.WriteLine(" "); //prints empty line
                Console.WriteLine("Play agian? (Y/N)");
                Console.WriteLine(" ");

                System.ConsoleKeyInfo input = Console.ReadKey(true);

                while(input.Key != ConsoleKey.Y || input.Key != ConsoleKey.N)
                {
                    if (input.Key == ConsoleKey.Y)
                    {
                        break;
                    }

                    if (input.Key == ConsoleKey.N)
                    {
                        isPlaying = false;
                        break;
                    }

                    input = Console.ReadKey(true);
                }
            }
        }

        static int GenerateRandomInt(int min, int max, Random random)
        {
            return random.Next(min, max + 1);
        }
    }
}
