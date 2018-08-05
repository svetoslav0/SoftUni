using System;

namespace _02._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the count of every flower and the present price from the console
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            // Calculate the net
            double totalMoneyEarned = magnolia * 3.25 + hyacinths * 4 + roses * 3.5 + cacti * 8;
            double net = totalMoneyEarned * 0.95;

            // Check if the money would be enough and print the result
            if (net >= presentPrice)
            {
                double moneyLeft = Math.Floor(net - presentPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyNeeded = Math.Ceiling(presentPrice - net);
                Console.WriteLine($"She will have to borrow {moneyNeeded} leva.");
            }
        }
    }
}
