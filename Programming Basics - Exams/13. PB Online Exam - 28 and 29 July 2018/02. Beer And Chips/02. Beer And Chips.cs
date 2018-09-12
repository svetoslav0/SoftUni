using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beersCount = double.Parse(Console.ReadLine());
            double chipsCount = double.Parse(Console.ReadLine());

            double beersPrice = 1.2 * beersCount;
            double chipsPrice = Math.Ceiling(0.45 * beersPrice * chipsCount);
            double totalPrice = beersPrice + chipsPrice;

            if (totalPrice > budget)
            {
                Console.WriteLine($"{name} needs {totalPrice - budget:f2} more leva!");
            }
            else
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalPrice:f2} leva left.");
            }
        }
    }
}
