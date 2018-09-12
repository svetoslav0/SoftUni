using System;

namespace _05._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());
            double totalSales = 0;
            double totalRating = 0;

            for (int i = 0; i < computers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int rating = currentNumber % 10;
                int possibleSales = currentNumber / 10;
                totalRating += rating;

                switch (rating)
                {
                    case 3:
                        totalSales += 0.5 * possibleSales;
                        break;
                    case 4:
                        totalSales += 0.7 * possibleSales;
                        break;
                    case 5:
                        totalSales += 0.85 * possibleSales;
                        break;
                    case 6:
                        totalSales += possibleSales;
                        break;
                }
            }

            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{totalRating / computers:f2}");
        }
    }
}
