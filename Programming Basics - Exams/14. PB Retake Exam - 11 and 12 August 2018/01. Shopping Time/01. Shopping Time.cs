using System;

namespace _01._Shopping_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTime = double.Parse(Console.ReadLine());
            double pricePerPiece = double.Parse(Console.ReadLine());
            double pricePerProgram = double.Parse(Console.ReadLine());
            double pricePerFrappe = double.Parse(Console.ReadLine());

            double restTime = totalTime - 15;
            double moneySpend = pricePerPiece * 3 + pricePerProgram * 2 + pricePerFrappe;

            Console.WriteLine($"{moneySpend:f2}");
            Console.WriteLine($"{restTime}");
        }
    }
}
