using System;

namespace _3___Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string campOrHotel = "";
            double cost = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    cost = 0.3 * budget;
                }
                else
                {
                    campOrHotel = "Hotel";   // DONE
                    cost = 0.7 * budget;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    cost = 0.4 * budget;
                }
                else
                {
                    campOrHotel = "Hotel";
                    cost = 0.8 * budget;
                }
            }
            else
            {
                destination = "Europe";
                campOrHotel = "Hotel";    // DONE!
                cost = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {cost:f2}");
        }
    }
}
