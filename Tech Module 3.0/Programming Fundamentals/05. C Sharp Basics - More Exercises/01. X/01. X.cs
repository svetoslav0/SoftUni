using System;

namespace _01._X
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int m = 1;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', n - 2 - 2 * i)}x");
            }
            Console.WriteLine($"{new string(' ', (n - 1) / 2)}x");
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', m)}x");
                m += 2;
            }
        }
    }
}