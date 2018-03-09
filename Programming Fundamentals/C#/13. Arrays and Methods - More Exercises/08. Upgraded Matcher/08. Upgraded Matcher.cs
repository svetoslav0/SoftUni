using System;
using System.Linq;

namespace _08._Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = new long[products.Length];
            long[] quantitiesString = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (int i = 0; i < quantitiesString.Length; i++)
            {
                quantities[i] = quantitiesString[i];
            }
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            while (true)
            {
                string[] search = Console.ReadLine().Split();
                string product = search[0];
                if (search[0] == "done")
                {
                    break;
                }
                long quantity = long.Parse(search[1]);
                int index = Array.IndexOf(products, product);
                if (quantity <= quantities[index])
                {
                    Console.WriteLine($"{product} x {quantity} costs {prices[index]*quantity:f2}");
                    quantities[index] -= quantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product:f2}");
                }
            }
        }
    }
}
