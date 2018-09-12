using System;

namespace _01._Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double sectors = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double sectorIncome = capacity * ticketPrice / sectors;
            double totalEarnings = sectorIncome * sectors;
            double charityMoney = (totalEarnings - sectorIncome * 0.75) / 8;

            Console.WriteLine($"Total income - {totalEarnings:f2} BGN");
            Console.WriteLine($"Money for charity - {charityMoney:f2} BGN");
        }
    }
}
