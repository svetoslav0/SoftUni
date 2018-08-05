using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double runners = double.Parse(Console.ReadLine());
            double averageLaps = double.Parse(Console.ReadLine());
            double trackLength = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine()); // per day!!
            double moneyPerKm = double.Parse(Console.ReadLine());

            double totalCapacity = days * capacity;
            if (totalCapacity < runners)
            {
                runners = totalCapacity;
            }

            double totalMeters = runners * averageLaps * trackLength;
            double totalKm = totalMeters / 1000.0;
            double totalMoney = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");



        }
    }
}
