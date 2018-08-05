using System;

namespace _03._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the budget and the season from the console
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // Calculate the cost and select the class deppending on the budget
            if (budget <= 100)
            {
                Console.WriteLine($"Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {0.35 * budget:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {0.65 * budget:f2}");
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine($"Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {0.45 * budget:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {0.8 * budget:f2}");
                }
            }
            else
            {
                Console.WriteLine($"Luxury class");
                Console.WriteLine($"Jeep - {0.9 * budget:f2}");
            }
        }
    }
}
