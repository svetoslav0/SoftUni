using System;

namespace _02._Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double budget = double.Parse(Console.ReadLine());
            double totalHouseArea = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            double styrofoamArea = double.Parse(Console.ReadLine());
            double styrofoamPrice = double.Parse(Console.ReadLine());

            // Calculate the area and the price
            double houseArea = (totalHouseArea - windows * 2.4) * 1.1;
            double packsNeeded = Math.Ceiling(houseArea / styrofoamArea);
            double totalMoneyNeeded = packsNeeded * styrofoamPrice;

            // Check if the budget would be enough and print the result
            if (totalMoneyNeeded < budget)
            {
                Console.WriteLine($"Spent: {totalMoneyNeeded:f2}");
                Console.WriteLine($"Left: {budget - totalMoneyNeeded:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {totalMoneyNeeded - budget:f2}");
            }
        }
    }
}
