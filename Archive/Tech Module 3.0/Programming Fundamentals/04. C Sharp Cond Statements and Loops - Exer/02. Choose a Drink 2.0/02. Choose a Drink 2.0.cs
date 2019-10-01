using System;

namespace _02._Choose_a_Drink_2._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.7;
                    break;

                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1.0;
                    break;

                case "SoftUni Student":
                    totalPrice = quantity * 1.7;
                    break;

                default:
                    totalPrice = quantity * 1.2;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}