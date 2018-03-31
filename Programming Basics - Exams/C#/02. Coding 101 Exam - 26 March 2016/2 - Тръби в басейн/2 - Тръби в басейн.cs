using System;

namespace _2___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipeOne = double.Parse(Console.ReadLine());
            double pipeTwo = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double firstLiters = pipeOne * hours;
            double secondLiters = pipeTwo * hours;
            double totalLiters = firstLiters + secondLiters;
            double totalPercentage = totalLiters / volume * 100;
            if (totalPercentage > 100)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {totalLiters - volume:f1} liters.");
            }
            else
            {
                double firstPercentage = (int)(firstLiters / totalLiters * 100);
                double secondPercentage = (int)(secondLiters / totalLiters * 100);
                Console.WriteLine($"The pool is {(int)totalPercentage}% full. Pipe 1: {(int)firstPercentage}%. Pipe 2: {secondPercentage}%.");
            }

        }
    }
}
