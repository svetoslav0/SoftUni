using System;

namespace _01._Training_Lab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Floor((w - 1) / 0.7) * Math.Floor(h / 1.2) - 3);
        }
    }
}