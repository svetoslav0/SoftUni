using System;

namespace _02._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input data from the console
            double amount = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeigth = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double moneyForWork = double.Parse(Console.ReadLine());

            // Calculate how many tiles and money would be needed
            double floorArea = floorLenght * floorWidth;
            double tileArea = triangleHeigth * triangleSide / 2;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;
            double totalMoneyNeeded = tilesNeeded * pricePerTile + moneyForWork;

            // Check if the amount would be enough and print the diff
            if (totalMoneyNeeded > amount)
            {
                double diff = totalMoneyNeeded - amount;
                Console.WriteLine($"You'll need {diff:f2} lv more.");
            }
            else
            {
                double diff = amount - totalMoneyNeeded;
                Console.WriteLine($"{diff:f2} lv left.");
            }
        }
    }
}
