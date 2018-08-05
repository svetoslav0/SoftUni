using System;

namespace _03._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            double people = double.Parse(Console.ReadLine());
            double transportPrice = 0.0;
            double totalTicketsPrice = 0.0;

            // Distribute the transport budget depending on how many people are going
            if (people >= 1 && people <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else if (people > 49)
            {
                transportPrice = budget * 0.25;
            }

            // Calculate the tickets' price
            switch (type)
            {
                case "normal":
                    totalTicketsPrice = 249.99 * people;
                    break;
                case "vip":
                    totalTicketsPrice = 499.99 * people;
                    break;
            }

            // Check if the bugdet is enough and print the result
            if (budget >= totalTicketsPrice + transportPrice)
            {
                double moneyLeft = budget - (totalTicketsPrice + transportPrice);
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalTicketsPrice + transportPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }

        }
    }
}
