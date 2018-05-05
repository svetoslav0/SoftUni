using System;

namespace _01._Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input data from the console
            double workingDays = double.Parse(Console.ReadLine());
            double dollarsPerDay = double.Parse(Console.ReadLine());
            double dollarRate = double.Parse(Console.ReadLine());

            // Calculate annual income in dollars
            double dollarsPerMonth = workingDays * dollarsPerDay;
            double incomeInDollars = dollarsPerMonth * 14.5 * 0.75;

            // Annual income in levas per day
            double incomeInLv = incomeInDollars * dollarRate;
            double levasPerDays = incomeInLv / 365.0;

            // Print the result
            Console.WriteLine($"{levasPerDays:f2}");


        }
    }
}
