using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Birthday (month day): ");
            string birthdayStr = Console.ReadLine();

            var birthday = DateTime.Parse(birthdayStr);
            var now = DateTime.Now;

            DateTime birthdayWithCorrectYear = new DateTime();

            if(birthday.Year < now.Year)
            {
                if(birthday.Month < now.Month)
                {
                    birthdayWithCorrectYear = birthday.AddYears(now.Year - birthday.Year + 1);
                }
                else
                {
                    birthdayWithCorrectYear = birthday.AddYears(now.Year - birthday.Year);
                }
            }
           
            var difference = birthdayWithCorrectYear - now;

            Console.WriteLine($"Hello {firstName} {lastName}, your birthday is in {Convert.ToInt32(difference.TotalDays)} days");
            Console.ReadLine();
        }
    }
}
