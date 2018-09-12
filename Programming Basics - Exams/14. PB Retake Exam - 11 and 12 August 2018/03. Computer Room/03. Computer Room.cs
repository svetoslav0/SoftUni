using System;

namespace _03._Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hoursSpend = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double totalCost = 0.0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (dayOrNight == "day")
                    {
                        totalCost = 10.5 * hoursSpend * people;
                    }
                    else if (dayOrNight == "night")
                    {
                        totalCost = 8.4 * hoursSpend * people;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (dayOrNight == "day")
                    {
                        totalCost = 12.6 * hoursSpend * people;
                    }
                    else if (dayOrNight == "night")
                    {
                        totalCost = 10.2 * hoursSpend * people;
                    }
                    break;
            }

            if (people >= 4)
            {
                totalCost *= 0.9;
            }

            if (hoursSpend >= 5)
            {
                totalCost *= 0.5;
            }

            Console.WriteLine($"Price per person for one hour: {totalCost / people / hoursSpend:f2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:f2}");
        }
    }
}
