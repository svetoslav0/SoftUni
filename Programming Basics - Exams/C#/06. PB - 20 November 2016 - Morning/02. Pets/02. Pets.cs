using System;

namespace _02._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the total time, the total food that the pets 
            // have for that time and how much everyone needs per day
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine()); // kg
            double catFood = double.Parse(Console.ReadLine()); // kg
            double turtleFood = double.Parse(Console.ReadLine()); // g !!!

            // This line calculates the total food that the pets would eat
            double totalFood = days * (dogFood + catFood + turtleFood / 1000);

            // Check if the total would be enough and print the result
            if (food >= totalFood)
            {
                double foodLeft = food - totalFood;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodNeeded = totalFood - food;
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }





        }
    }
}
