using System;

namespace _05._Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number from the console
            int n = int.Parse(Console.ReadLine());

            // Print the upper part
            string lineOfStars = new string('*', 2 * n + 1);
            Console.WriteLine(lineOfStars);
            for (int i = 0; i < n - 1; i++)
            {
                string dots = new string('.', i + 1);
                string lineOfAts = new string('@', 2 * n - 2 * i - 3);
                Console.Write($"{dots}*");
                if (i == 0)
                {
                    Console.Write($"{new string(' ', 2 * n - 3)}");
                }
                else
                {
                    Console.Write($"{lineOfAts}");
                }
                Console.WriteLine($"*{dots}");
            }

            // Print the middle line
            Console.WriteLine($"{new string('.', n)}*{new string('.', n)}");

            // Print the bottom of the clock
            for (int i = 0; i < n - 1; i++)
            {
                string dots = new string('.', n - i - 1);

                Console.Write($"{dots}*");
                if (i == n - 2)
                {
                    Console.Write($"{new string('@', 2 * n - 3)}");
                }
                else
                {
                    string spaces = new string(' ', i);
                    Console.Write($"{spaces}@{spaces}");
                }
                Console.WriteLine($"*{dots}");
            }
            Console.WriteLine($"{lineOfStars}");


        }
    }
}
