using System;

namespace _05._Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string topStars = new string('*', i + 1);
                string topDashes = new string('-', 2 * n - 1 - 2 * i);
                Console.WriteLine($@"{topStars}\{topDashes}/{topStars}");
            }

            for (int i = 0; i < n / 3; i++)
            {
                string middleSideStars = new string('*', (n - 1) / 2 + i);
                string middleStars = new string('*', n - 2 * i);
                Console.WriteLine($@"|{middleSideStars}\{middleStars}/{middleSideStars}|");
            }

            for (int i = 0; i < n; i++)
            {
                string bottomSideDashes = new string('-', i + 1);
                string bottomMiddleStars = new string('*', 2 * n - 1 - 2 * i);
                Console.WriteLine($@"{bottomSideDashes}\{bottomMiddleStars}/{bottomSideDashes}");

            }
        }
    }
}
