using System;

namespace _03._Restaurant_Discount
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var people = double.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            string hall;
            double price = 0.0;
            if (people <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (people > 50 && people <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else
            {
                hall = "Great Hall";
                price = 7500;
            }
            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                switch (package)
                {
                    case "normal":
                        price += 500;
                        price *= 0.95;
                        break;

                    case "gold":
                        price += 750;
                        price *= 0.9;
                        break;

                    case "platinum":
                        price += 1000;
                        price *= 0.85;
                        break;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {price / people:f2}$");
            }
        }
    }
}