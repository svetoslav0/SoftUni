using System;

namespace _01._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the prices and the quantity of the products
            double mackerelPrice = double.Parse(Console.ReadLine()); // Скумрия
            double spratPrice = double.Parse(Console.ReadLine());    // Цаца
            double palmwoodQuantity = double.Parse(Console.ReadLine()); // Паламуд
            double horseMackerelQuantity = double.Parse(Console.ReadLine()); // Сафрид
            double musselsQuantity = double.Parse(Console.ReadLine());  // Миди

            // Find the needed prices
            double palmwoodPrice = mackerelPrice * 1.6;
            double palmwoodTotalCost = palmwoodPrice * palmwoodQuantity;
            double horseMackerelPrice = spratPrice * 1.8;
            double horseMackarelTotalCost = horseMackerelPrice * horseMackerelQuantity;
            double musselsTotalCost = musselsQuantity * 7.5;

            // Print the total money that would be needed
            double totalCost = palmwoodTotalCost + horseMackarelTotalCost + musselsTotalCost;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
