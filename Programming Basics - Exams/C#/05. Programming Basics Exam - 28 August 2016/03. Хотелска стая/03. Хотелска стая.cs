using System;

namespace _03._Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input data from the console
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            // Reckon the prices depending on the input data
            switch (month)
            {
                case "may":
                case "october":
                    apartmentPrice = 65 * nights;
                    studioPrice = 50 * nights;
                    break;
                case "june":
                case "september":
                    apartmentPrice = 68.7 * nights;
                    studioPrice = 75.2 * nights;
                    break;
                case "july":
                case "august":
                    apartmentPrice = 77 * nights;
                    studioPrice = 76 * nights;
                    break;
            }

            // Calculate the discount
            if (nights > 14 && (month == "june" || month == "september"))
            {
                studioPrice *= 0.8;
            }
            else if (nights > 14 && (month == "may" || month == "october"))
            {
                studioPrice *= 0.7;
            }
            else if (nights > 7 && (month == "may" || month == "october"))
            {
                studioPrice *= 0.95;
            }

            if (nights > 14)
            {
                apartmentPrice *= 0.9;
            }

            // Print the prices
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
