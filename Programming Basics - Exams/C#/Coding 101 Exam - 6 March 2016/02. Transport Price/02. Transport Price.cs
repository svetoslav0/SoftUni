using System;

namespace _02._Transport_Price
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (km >= 100)
            {
                Console.WriteLine(km * 0.06);
            }
            else if (km >= 20)
            {
                Console.WriteLine(km * 0.09);
            }
            else
            {
                if (type == "day")
                {
                    Console.WriteLine(0.7 + 0.79 * km);
                }
                else if (type == "night")
                {
                    Console.WriteLine(0.7 + 0.9 * km);
                }
            }
        }
    }
}