using System;

namespace _01._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input prices and quantities from the console
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            // Calculate the rakia's, the wine's and the beer's price
            double rakiaPrice = whiskeyPrice / 2.0;
            double winePrice = rakiaPrice - rakiaPrice * 0.4;
            double beerPrice = rakiaPrice - rakiaPrice * 0.8;

            // Calculate and print the final price
            double result = whiskeyPrice * whiskeyQuantity + beerPrice * beerQuantity + winePrice * wineQuantity + rakiaPrice * rakiaQuantity;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
