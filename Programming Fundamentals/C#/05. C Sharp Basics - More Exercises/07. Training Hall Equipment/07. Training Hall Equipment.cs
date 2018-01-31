using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var items = double.Parse(Console.ReadLine());
            string item = "";
            double itemPrice = 0.0;
            double quantity = 0.0;
            double sum = 0.0;
            for (int i = 0; i < items; i++)
            {
                item = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                quantity = double.Parse(Console.ReadLine());
                sum += itemPrice * quantity;
                if (quantity == 1)
                {
                    Console.WriteLine($"Adding 1 {item} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {quantity} {item}s to cart.");
                }
            }
            Console.WriteLine($"Subtotal: ${sum:f2}");
            if (sum > budget)
            {
                Console.WriteLine($"Not enough. We need ${sum-budget:f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget-sum:f2}");
            }
        }
    }
}
