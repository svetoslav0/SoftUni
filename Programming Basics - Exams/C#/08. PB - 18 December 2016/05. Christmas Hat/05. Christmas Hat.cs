using System;

namespace _05._Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input number from the console
            int n = int.Parse(Console.ReadLine());

            // Print the top of the hat
            string sideDots = new string('.', 2 * n - 1);
            Console.WriteLine($@"{sideDots}/|\{sideDots}");
            Console.WriteLine($@"{sideDots}\|/{sideDots}");

            // Print the middle part
            for (int i = 0; i < 2 * n; i++)
            {
                sideDots = new string('.', 2 * n - i - 1);
                string dashes = new string('-', i);
                Console.WriteLine($"{sideDots}*{dashes}*{dashes}*{sideDots}");
            }

            // Print the base of the hat
            string lineOfStars = new string('*', 4 * n + 1);
            Console.WriteLine(lineOfStars);
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(lineOfStars);
        }
    }
}
