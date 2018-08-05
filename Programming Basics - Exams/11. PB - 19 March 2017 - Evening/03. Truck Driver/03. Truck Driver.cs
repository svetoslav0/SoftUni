using System;

namespace _03._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the season and the kilometers from the console
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double salary = 0.0;

            // Calculate the salary depending on the season and the kilometers
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kilometers <= 5000)
                    {
                        salary = 0.75 * kilometers;
                    }
                    else if (kilometers <= 10000)
                    {
                        salary = 0.95 * kilometers;
                    }
                    else if (kilometers <= 20000)
                    {
                        salary = 1.45 * kilometers;
                    }
                    break;
                case "Summer":
                    if (kilometers <= 5000)
                    {
                        salary = 0.9 * kilometers;
                    }
                    else if (kilometers <= 10000)
                    {
                        salary = 1.1 * kilometers;
                    }
                    else if (kilometers <= 20000)
                    {
                        salary = 1.45 * kilometers;
                    }
                    break;
                case "Winter":
                    if (kilometers <= 5000)
                    {
                        salary = 1.05 * kilometers;
                    }
                    else if (kilometers <= 10000)
                    {
                        salary = 1.25 * kilometers;
                    }
                    else if (kilometers <= 20000)
                    {
                        salary = 1.45 * kilometers;
                    }
                    break;
            }
            double totalMoney = salary * 3.6;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
