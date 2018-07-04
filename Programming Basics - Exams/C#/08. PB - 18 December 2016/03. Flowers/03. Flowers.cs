using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double chrysanthemums = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isHoliday = char.Parse(Console.ReadLine());

            // Calculate the price deppending on the season
            double cleanPrice = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                cleanPrice = chrysanthemums * 2 + roses * 4.1 + tulips * 2.5;
            }
            else
            {
                cleanPrice = chrysanthemums * 3.75 + roses * 4.5 + tulips * 4.15;
            }

            // Increase the price if it's holiday
            double totalPrice = cleanPrice;
            if (isHoliday == 'Y')
            {
                totalPrice *= 1.15;
            }

            // ReCalculate the price with discounts
            if (season == "Spring" && tulips > 7)
            {
                totalPrice *= 0.95;
            }

            if (season == "Winter" && roses >= 10)
            {
                totalPrice *= 0.90;
            }

            if (chrysanthemums + roses + tulips > 20)
            {
                totalPrice *= 0.80;
            }

            // Print the final price of the flowers
            Console.WriteLine($"{totalPrice + 2:f2}");
        }
    }
}
