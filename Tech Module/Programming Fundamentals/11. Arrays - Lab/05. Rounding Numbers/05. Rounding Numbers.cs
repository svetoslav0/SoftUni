using System;
using System.Linq;
namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numsText = Console.ReadLine();
            double[] numbers = numsText
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            foreach (var current in numbers)
            {
                Console.WriteLine($"{current} => {Math.Round(current, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
