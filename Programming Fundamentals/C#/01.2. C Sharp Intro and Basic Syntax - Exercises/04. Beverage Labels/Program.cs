using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var nrg = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {drink}:");
            Console.WriteLine($"{volume * nrg / 100}kcal, {volume * sugar / 100}g sugars");
        }
    }
}
