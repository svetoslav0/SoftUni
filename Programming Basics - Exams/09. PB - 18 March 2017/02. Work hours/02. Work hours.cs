using System;

namespace _02._Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double hoursNeeded = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            // Calculate the hours and check if they would be enough
            double totalWorkingHours = workers * workingDays * 8;
            if (totalWorkingHours > hoursNeeded)
            {
                double diff = totalWorkingHours - hoursNeeded;
                Console.WriteLine($"{diff} hours left");
            }
            else
            {
                double diff = hoursNeeded - totalWorkingHours;
                double penalties = diff * workingDays;
                Console.WriteLine($"{diff} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }

        }
    }
}
