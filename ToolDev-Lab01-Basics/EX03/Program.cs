using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers separated by spaces:");
            string input = Console.ReadLine();

            Int32 count = 0;
            foreach (char ch in input)
            {
                if (ch == ' ')
                    ++count;
            }

            count += 1; //there is always 1 more numbers then spaces
           
            string[] separators = { " " };
            string[] numbers = input.Split(separators, count, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;
            double product = 1.0;
            
            foreach (string number in numbers)
            {
                sum += double.Parse(number, CultureInfo.InvariantCulture);
                product *= double.Parse(number, CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Product = {product}");

            Console.ReadLine(); ////to make the console not close automatically
        }
    }
}
