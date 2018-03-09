using System;
using System.Linq;

namespace _07._Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            while (true)
            {
                string search = Console.ReadLine();
                if (search == "done")
                {
                    break;
                }
                int index = Array.IndexOf(products, search);
                Console.WriteLine($"{search} costs: {prices[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}
