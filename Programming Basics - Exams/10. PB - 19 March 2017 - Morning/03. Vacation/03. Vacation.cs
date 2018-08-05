using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string accommodation = "";
            double price = 0.0;

            // Select the destination, the accommodation and calculate the price depending on the input data
            if (budget <= 1000)
            {
                accommodation = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    price = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    price = 0.45 * budget;
                }
            }
            else if (budget <= 3000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    price = 0.8 * budget;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    price = 0.6 * budget;
                }

            }
            else
            {
                accommodation = "Hotel";
                price = 0.9 * budget;
                if (season == "Summer")
                {
                    destination = "Alaska";
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                }
            }

            // Print the destination, accommodation and the price
            Console.WriteLine($"{destination} - {accommodation} - {price:f2}");
        }
    }
}
