using System;

namespace _01._House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double firstRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSquare = double.Parse(Console.ReadLine());

            // Calculate the area of the other rooms and the total area
            double secondRoomArea = firstRoomArea * 1.1;
            double thirdRoomArea = secondRoomArea * 1.1;
            double bathroomArea = firstRoomArea / 2;
            double totalRoomsArea = firstRoomArea + secondRoomArea + thirdRoomArea + kitchenArea + bathroomArea;
            double totalArea = totalRoomsArea * 1.05 * pricePerSquare;

            // Print the result
            Console.WriteLine($"{totalArea:f2}");
        }
    }
}
