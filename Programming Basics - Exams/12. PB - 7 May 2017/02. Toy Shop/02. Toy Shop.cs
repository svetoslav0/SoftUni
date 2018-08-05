using System;

namespace _02._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            double tripPrice = double.Parse(Console.ReadLine());
            double numberPuzzles = double.Parse(Console.ReadLine());
            double numberDolls = double.Parse(Console.ReadLine());
            double numberBears = double.Parse(Console.ReadLine());
            double numberMinions = double.Parse(Console.ReadLine());
            double numberTrucks = double.Parse(Console.ReadLine());

            // Calculate the total sum and the total toys
            double sum = numberPuzzles * 2.6 + numberDolls * 3 + numberBears * 4.1 + numberMinions * 8.2 + numberTrucks * 2;
            double totalToys = numberPuzzles + numberDolls + numberBears + numberMinions + numberTrucks;
            double moneyLeft = 0.0; //restmoney

            // If toys >= 50 => 25% - donation :)
            if (totalToys >= 50)
            {
                sum *= 0.75;
                moneyLeft = sum * 0.9;
            }
            else
            {
                moneyLeft = sum * 0.9;
            }

            // Check if the money would be enough and print the result
            if (moneyLeft >= tripPrice)
            {
                Console.WriteLine($"Yes! {(moneyLeft - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice - moneyLeft):f2} lv needed.");
            }
        }
    }
}
