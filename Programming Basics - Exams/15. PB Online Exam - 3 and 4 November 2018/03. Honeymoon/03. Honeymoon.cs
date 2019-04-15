using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine().ToLower();
            double nights = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            // Base prices
            switch (city)
            {
                case "cairo":
                    totalPrice = 250 * nights * 2 + 600;
                    break;
                case "paris":
                    totalPrice = 150 * nights * 2 + 350;
                    break;
                case "lima":
                    totalPrice = 400 * nights * 2 + 850;
                    break;
                case "new york":
                    totalPrice = 300 * nights * 2 + 650;
                    break;
                case "tokyo":
                    totalPrice = 350 * nights * 2 + 700;
                    break;
            }

            // Discounts
            if (nights >= 1 && nights <= 4)
            {
                if (city == "cairo" || city == "new york")
                {
                    totalPrice *= 0.97;
                }
            }
            else if(nights >= 5 && nights <= 9)
            {
                if (city == "cairo" || city == "new york")
                {
                    totalPrice *= 0.95;
                }
                else if (city == "paris")
                {
                    totalPrice *= 0.93;
                }
            }
            else if(nights >= 10 && nights <= 24)
            {
                if (city == "cairo")
                {
                    totalPrice *= 0.9;
                }
                else if (city == "paris" || city == "new york" || city == "tokyo")
                {
                    totalPrice *= 0.88;
                }
            }
            else if (nights >= 25 && nights <= 49)
            {
                if (city == "tokyo" || city == "cairo")
                {
                    totalPrice *= 0.83;
                }
                else if (city == "new york" || city == "lima")
                {
                    totalPrice *= 0.81;
                }
                else if (city == "paris")
                {
                    totalPrice *= 0.78;
                }
            }
            else if (nights >= 50)
            {
                totalPrice *= 0.7;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:f2} leva.");
            }

        }
    }
}
