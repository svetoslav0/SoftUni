using System;
using System.Collections.Generic;

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal key = decimal.Parse(Console.ReadLine());
            List<string> sites = new List<string>();
            decimal totalLoss = 0.0m;
            decimal token = Power(key, n);
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split();
                sites.Add(data[0]);
                totalLoss += decimal.Parse(data[1]) * decimal.Parse(data[2]);
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {token:f0}");

        }

        private static decimal Power(decimal key, decimal n)
        {
            decimal result = 1.0m;
            for (long i = 0; i < n; i++)
            {
                result *= key;
            }
            return result;
        }
    }
}
