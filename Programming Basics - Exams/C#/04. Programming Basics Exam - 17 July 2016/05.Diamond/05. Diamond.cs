using System;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number from the console
            int n = int.Parse(Console.ReadLine());

            // Print the first line
            string firstDots = new string('.', n);
            string firstStars = new string('*', 3 * n);
            Console.WriteLine($"{firstDots}{firstStars}{firstDots}");

            // Print the top of the diamond
            for (int i = 0; i < n - 1; i++)
            {
                string topSideDots = new string('.', n - 1 - i);
                string topMiddleDots = new string('.', 3 * n + 2 * i);
                Console.WriteLine($"{topSideDots}*{topMiddleDots}*{topSideDots}");
            }

            // Print the middle line
            string middleLine = new string('*', 5 * n);
            Console.WriteLine($"{middleLine}");

            // Print the bottom part of the diamond
            for (int i = 0; i < 2 * n + 1; i++)
            {
                string bottomSideDots = new string('.', i + 1);
                string bottomMiddleDots = new string('.', 5 * n - 4 - 2 * i);
                string bottomMiddleStars = new string('*', n - 4);
                if (i != 2 * n)
                {
                    Console.WriteLine($"{bottomSideDots}*{bottomMiddleDots}*{bottomSideDots}");
                }
                else
                {
                    Console.WriteLine($"{bottomSideDots}*{bottomMiddleStars}*{bottomSideDots}");
                }

            }

        }
    }
}
