using System;

namespace _02._Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double plannedCups = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            // Calculate the cups that will be made
            double totalHours = workers * workingDays * 8;
            double cupsMade = Math.Floor(totalHours / 5);

            // Check if the cups will be enough and print the extra or lost money
            if (cupsMade > plannedCups)
            {
                Console.WriteLine($"{(cupsMade - plannedCups) * 4.2:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {(plannedCups - cupsMade) * 4.2:f2}");
            }
        }
    }
}
