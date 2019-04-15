using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double guestsCount = 0;
            double moneyCollected = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "The restaurant is full")
                {
                    break;
                }

                double people = double.Parse(command);
                guestsCount += people;

                if (people < 5)
                {
                    moneyCollected += people * 100;
                }
                else
                {
                    moneyCollected += people * 70;
                }
            }

            if (moneyCollected >= moneyNeed)
            {
                double moneyDiff = moneyCollected - moneyNeed;
                Console.WriteLine($"You have {guestsCount} guests and {moneyDiff} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guestsCount} guests and {moneyCollected} leva income, but no singer.");
            }
        }
    }
}
