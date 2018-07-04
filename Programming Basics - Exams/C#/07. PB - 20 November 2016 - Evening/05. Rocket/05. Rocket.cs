using System;

namespace _05._Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Print the top of the rocket
            for (int i = 0; i < n; i++)
            {
                string dots = new string('.', 3 * n / 2 - 1 - i);
                string spaces = new string(' ', 2 * i);
                Console.WriteLine($@"{dots}/{spaces}\{dots}");
            }
            string sideDots = new string('.', n / 2);
            string upperStars = new string('*', 2 * n);
            Console.WriteLine($"{sideDots}{upperStars}{sideDots}");

            // Print the body of the rocket
            for (int i = 0; i < 2 * n; i++)
            {
                string filling = new string('\\', 2 * n - 2);
                Console.WriteLine($"{sideDots}|{filling}|{sideDots}");
            }

            // Print the base
            for (int i = 0; i < n / 2; i++)
            {
                string dots = new string('.', n / 2 - i);
                string filling = new string('*', 2 * n - 2 + 2 * i);
                Console.WriteLine($@"{dots}/{filling}\{dots}");
            }

        }
    }
}
