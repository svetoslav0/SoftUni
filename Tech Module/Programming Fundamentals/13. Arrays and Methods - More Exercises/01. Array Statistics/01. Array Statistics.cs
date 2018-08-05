using System;
using System.Linq;
namespace _01._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            int sum = numbers.Sum();
            double average = numbers.Average();
            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
