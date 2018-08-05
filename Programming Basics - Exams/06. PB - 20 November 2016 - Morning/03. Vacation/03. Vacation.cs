using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input data from the console
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();

            double transportPrice = 0.0;

            // Find the fees depending on the transport type
            switch (transportType)
            {
                case "train":
                    transportPrice = adults * 24.99 + students * 14.99;
                    break;
                case "bus":
                    transportPrice = adults * 32.5 + students * 28.5;
                    break;
                case "boat":
                    transportPrice = adults * 42.99 + students * 39.99;
                    break;
                case "airplane":
                    transportPrice = adults * 70 + students * 50;
                    break;
            }
            transportPrice *= 2;

            // In case of the group is more than 50 
            // and they travel by train they get 50% discount
            if (transportType == "train" && adults + students >= 50)
            {
                transportPrice /= 2;
            }

            // Calculate the total price and print the result
            double hotelPrice = nights * 82.99;
            double totalPrice = (transportPrice + hotelPrice) * 1.1;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
