using System;

namespace _02._Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double consumptionPerHundred = double.Parse(Console.ReadLine());
            double gasolinePrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalConsumption = distance * consumptionPerHundred / 100;
            double totalMoneyCost = totalConsumption * gasolinePrice;

            if (totalMoneyCost <= budget)
            {
                Console.WriteLine($"You can go home. {budget - totalMoneyCost:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {budget / 5.0:f2} money.");
            }


        }
    }
}
