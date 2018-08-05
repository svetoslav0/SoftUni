using System;

namespace _03._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the season, the type of the group, the students
            // and the nights from the console
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = "";
            double totalPricePerNight = 0.0;

            // Select the sport and calculate the price
            // depending on the gruop type and the season
            switch (groupType)
            {
                case "girls":
                    if (season == "Winter")
                    {
                        totalPricePerNight = 9.6 * students;
                        sport = "Gymnastics";
                    }
                    else if (season == "Spring")
                    {
                        totalPricePerNight = 7.2 * students;
                        sport = "Athletics";
                    }
                    else if (season == "Summer")
                    {
                        totalPricePerNight = 15 * students;
                        sport = "Volleyball";
                    }
                    break;
                case "boys":
                    if (season == "Winter")
                    {
                        totalPricePerNight = 9.6 * students;
                        sport = "Judo";
                    }
                    else if (season == "Spring")
                    {
                        totalPricePerNight = 7.2 * students;
                        sport = "Tennis";
                    }
                    else if (season == "Summer")
                    {
                        totalPricePerNight = 15 * students;
                        sport = "Football";
                    }
                    break;
                case "mixed":
                    if (season == "Winter")
                    {
                        totalPricePerNight = 10 * students;
                        sport = "Ski";
                    }
                    else if (season == "Spring")
                    {
                        totalPricePerNight = 9.5 * students;
                        sport = "Cycling";
                    }
                    else if (season == "Summer")
                    {
                        totalPricePerNight = 20 * students;
                        sport = "Swimming";
                    }
                    break;
            }

            // Calculate the discount
            if (students >= 50)
            {
                totalPricePerNight *= 0.5;
            }
            else if (students >= 20)
            {
                totalPricePerNight *= 0.85;
            }
            else if (students >= 10)
            {
                totalPricePerNight *= 0.95;
            }

            // Print the calculated price and the selected sport
            Console.WriteLine($"{sport} {totalPricePerNight * nights:f2} lv.");
        }
    }
}
