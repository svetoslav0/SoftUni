using System;

namespace _01._Money
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            double bitcoins = double.Parse(Console.ReadLine());
            double yens = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            // Calculate bicoins and yens to levs
            double totalLevs = bitcoins * 1168 + yens * 0.15 * 1.76;
            double totalEuros = totalLevs / 1.95;
            double result = totalEuros - totalEuros * commision / 100;

            // Print the result
            Console.WriteLine($"{result:f2}");


        }
    }
}
