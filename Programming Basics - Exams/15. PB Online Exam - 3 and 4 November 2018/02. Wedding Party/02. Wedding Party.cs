using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestsCount = double.Parse(Console.ReadLine());
            double bugdet = double.Parse(Console.ReadLine());

            double couvertPrice = 20 * guestsCount;

            if (bugdet >= couvertPrice)
            {
                double moneyLeft = bugdet - couvertPrice;
                double fireworksMoney = 0.4 * moneyLeft;
                double donationMoney = moneyLeft - fireworksMoney;
                Console.WriteLine($"Yes! {Math.Round(fireworksMoney)} lv are for fireworks and {Math.Round(donationMoney)} lv are for donation.");
            }
            else
            {
                double moneyNeed = couvertPrice - bugdet;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(moneyNeed)} lv more.");
            }
        }
    }
}
