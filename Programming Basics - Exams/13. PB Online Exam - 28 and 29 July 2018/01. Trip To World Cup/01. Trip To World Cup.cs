using System;

namespace _01._Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double goingTicketPrice = double.Parse(Console.ReadLine());
            double comingTicketPrice = double.Parse(Console.ReadLine());
            double gameTicketPrice = double.Parse(Console.ReadLine());
            double gamesCount = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double planeTicketsPrice = 6 * (goingTicketPrice + comingTicketPrice);
            double travelPriceWithDiscount = planeTicketsPrice - planeTicketsPrice * discount / 100;
            double totalGamesPrice = 6 * gamesCount * gameTicketPrice;
            double totalPrice = travelPriceWithDiscount + totalGamesPrice;

            Console.WriteLine($"Total sum: {totalPrice:f2} lv.");
            Console.WriteLine($"Each friend has to pay {totalPrice / 6:f2} lv.");

        }
    }
}
