using System;

namespace _08._Sunglasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{new string('*', 2 * n)}{new string(' ', n)}{new string('*', 2 * n)}");
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 2) / 2 && n % 2 == 1)
                {
                    Console.WriteLine($"*{new string('/', 2 * n - 2)}*{new string('|', n)}*{new string('/', 2 * n - 2)}*");
                }
                else if (i == (n - 2) / 2 - 1 && n % 2 == 0)
                {
                    Console.WriteLine($"*{new string('/', 2 * n - 2)}*{new string('|', n)}*{new string('/', 2 * n - 2)}*");
                }
                else
                {
                    Console.WriteLine($"*{new string('/', 2 * n - 2)}*{new string(' ', n)}*{new string('/', 2 * n - 2)}*");
                }
            }

            Console.WriteLine($"{new string('*', 2 * n)}{new string(' ', n)}{new string('*', 2 * n)}");
        }
    }
}