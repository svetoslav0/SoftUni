using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double champagneQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double champagnePrice = whiskeyPrice * 0.5;
            double winePrice = champagnePrice * 0.4;
            double waterPrice = champagnePrice * 0.1;

            double totalMoney = whiskeyPrice * whiskeyQuantity + waterPrice * waterQuantity +
                winePrice * wineQuantity + champagnePrice * champagneQuantity;

            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
