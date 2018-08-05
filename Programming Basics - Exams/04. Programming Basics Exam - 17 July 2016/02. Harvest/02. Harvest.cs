using System;

namespace _02._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            double area = double.Parse(Console.ReadLine());
            double grapePerSquare = double.Parse(Console.ReadLine());
            double litersNeeded = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            // Make the calculations
            double totalGrape = area * grapePerSquare;
            double wine = 0.4 * totalGrape / 2.5;

            // Check if the wine is enough
            if (wine >= litersNeeded)
            {
                double wineLeft = wine - litersNeeded;
                double winePerPerson = wineLeft / workers;
                // Print the result
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");
            }
            else
            {
                double wineNeeded = litersNeeded - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded)} liters wine needed.");
            }
        }
    }
}
