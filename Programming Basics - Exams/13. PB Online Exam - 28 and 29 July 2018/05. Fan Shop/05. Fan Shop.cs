using System;

namespace _05._Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            double totalCost = 0.0;

            for (int i = 0; i < items; i++)
            {
                string currentItem = Console.ReadLine();

                switch (currentItem)
                {
                    case "hoodie":
                        totalCost += 30;
                        break;
                    case "keychain":
                        totalCost += 4;
                        break;
                    case "T-shirt":
                        totalCost += 20;
                        break;
                    case "flag":
                        totalCost += 15;
                        break;
                    case "sticker":
                        totalCost += 1;
                        break;
                }
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"You bought {items} items and left with {budget - totalCost} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalCost - budget} more lv.");
            }
        }
    }
}
