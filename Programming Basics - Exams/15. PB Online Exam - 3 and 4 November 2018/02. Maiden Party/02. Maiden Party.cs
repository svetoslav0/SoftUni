using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            double loveMessagesCount = double.Parse(Console.ReadLine());
            double rosesCount = double.Parse(Console.ReadLine());
            double keychainsCount = double.Parse(Console.ReadLine());
            double cartoonsCount = double.Parse(Console.ReadLine());
            double surpricesCount = double.Parse(Console.ReadLine());

            double totalPrice = loveMessagesCount * 0.6 + rosesCount * 7.2 +
                keychainsCount * 3.6 + cartoonsCount * 18.2 + surpricesCount * 22;

            if (loveMessagesCount + rosesCount + keychainsCount + cartoonsCount + surpricesCount >= 25)
            {
                totalPrice *= 0.65;
            }

            double earnings = totalPrice * 0.9;
            if (earnings >= partyPrice)
            {
                double moneyLeft = earnings - partyPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeed = partyPrice - earnings;
                Console.WriteLine($"Not enough money! {moneyNeed:f2} lv needed.");
            }
        }
    }
}
