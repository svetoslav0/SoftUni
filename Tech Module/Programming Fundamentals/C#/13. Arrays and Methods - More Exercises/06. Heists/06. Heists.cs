using System;
using System.Linq;

namespace _06._Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int jewelPrice = prices[0];
            int goldPrice = prices[1];
            long sumOfEarnings = 0;
            long sumOfExpenses = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Jail Time")
                {
                    break;
                }
                string[] heist = input.Split();
                char[] earnings = heist[0].ToCharArray();
                int expenses = int.Parse(heist[1]);
                sumOfExpenses += expenses;
                for (int i = 0; i < earnings.Length; i++)
                {
                    if (earnings[i] == '%')
                    {
                        sumOfEarnings += jewelPrice;
                    }
                    else if (earnings[i] == '$')
                    {
                        sumOfEarnings += goldPrice;
                    }
                }
            }
            if (sumOfExpenses > sumOfEarnings)
            {
                Console.WriteLine($"Have to find another job. Lost: {sumOfExpenses - sumOfEarnings}.");
            }
            else
            {
                Console.WriteLine($"Heists will continue. Total earnings: {sumOfEarnings - sumOfExpenses}.");
            }
        }
    }
}
