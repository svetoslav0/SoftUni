using System;

namespace _02._Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input data from the console
            double hoursNeeded = double.Parse(Console.ReadLine());
            double daysAvailable = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            // Calculate the data
            double totalTime = Math.Floor(8 * daysAvailable * 0.9 + workers * 2 * daysAvailable); // total time in hours

            // Check if the time would be enough
            if (totalTime >= hoursNeeded)
            {
                // Calculate the time that has left and print the result
                double timeLeft = totalTime - hoursNeeded;
                Console.WriteLine($"Yes!{timeLeft} hours left.");
            }
            else
            {
                double timeLack = hoursNeeded - totalTime;
                Console.WriteLine($"Not enough time!{timeLack} hours needed.");
            }

        }
    }
}
