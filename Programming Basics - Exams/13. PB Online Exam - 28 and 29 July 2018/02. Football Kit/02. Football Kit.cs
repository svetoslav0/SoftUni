using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double neededBill = double.Parse(Console.ReadLine());

            double shortsPrice = shirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double shoesPrice = (shirtPrice + shortsPrice) * 2;
            double totalPrice = shirtPrice + shortsPrice + socksPrice + shoesPrice;
            double priceWithDiscount = totalPrice * 0.85;

            if (priceWithDiscount > neededBill)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {priceWithDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededBill - priceWithDiscount:f2} lv. more.");
            }
        }
    }
}
