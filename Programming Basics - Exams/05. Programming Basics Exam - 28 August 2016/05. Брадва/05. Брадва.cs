using System;

namespace _05._Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a number from the console
            int n = int.Parse(Console.ReadLine());

            // Print the top part of the axe
            for (int i = 0; i < n; i++)
            {
                string topLeftDashes = new string('-', 3 * n);
                string topMiddleDashes = new string('-', i);
                string topRightDashes = new string('-', 2 * n - 2 - i); 
                Console.WriteLine($"{topLeftDashes}*{topMiddleDashes}*{topRightDashes}");
            }

            // Print the handle part
            for (int i = 0; i < n / 2; i++)
            {
                string handleOfStars = new string('*', 3 * n + 1);
                string middleDashes = new string('-', n - 1);
                Console.WriteLine($"{handleOfStars}{middleDashes}*{middleDashes}");
            }

            // Print the bottom part of the axe
            for (int i = 0; i < n / 2; i++)
            {
                char middleSymbol = '-';
                if (i == n / 2 - 1)
                {
                    middleSymbol = '*';
                }
                string bottomLeftDashes = new string('-', 3 * n - i);
                string bottomMiddle = new string(middleSymbol, n - 1 + 2 * i);
                string bottomRightDashes = new string('-', n - 1 - i);
                Console.WriteLine($"{bottomLeftDashes}*{bottomMiddle}*{bottomRightDashes}");
            }
        }
    }
}
