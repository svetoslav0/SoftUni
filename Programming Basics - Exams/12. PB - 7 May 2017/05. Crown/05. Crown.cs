using System;

namespace _05._Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number from the console
            int n = int.Parse(Console.ReadLine());

            string topSpaces = new string(' ', n - 2);
            Console.WriteLine($"@{topSpaces}@{topSpaces}@");

            Console.WriteLine($"**{new string(' ', n - 3)}*{new string(' ', n - 3)}**");

            for (int i = 0; i < n / 2 - 2; i++)
            {
                string sideDots = new string('.', i + 1);
                string middleDots = new string('.', 2 * i + 1);
                string middleSpaces = new string(' ', n - 5 - 2 * i);
                Console.WriteLine($"*{sideDots}*{middleSpaces}*{middleDots}*{middleSpaces}*{sideDots}*");
            }

            Console.WriteLine($"*{new string('.', n / 2 - 1)}*{new string('.', n - 3)}*{new string('.', n / 2 - 1)}*");

            Console.WriteLine($"*{new string('.', n / 2)}{new string('*', n / 2 - 2)}.{new string('*', n / 2 - 2)}{new string('.', n / 2)}*");

            Console.WriteLine($"{new string('*', 2 * n - 1)}");
            Console.WriteLine($"{new string('*', 2 * n - 1)}");
        }
    }
}
