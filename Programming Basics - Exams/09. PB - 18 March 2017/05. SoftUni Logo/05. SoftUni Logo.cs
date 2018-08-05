using System;

namespace _05._SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the main number
            int n = int.Parse(Console.ReadLine());

            // Print the top part of the figure
            for (int i = 0; i < 2 * n; i++)
            {
                string dots = new string('.', 6 * n - 3 * i - 3);
                string sharps = new string('#', 1 + 6 * i);
                Console.WriteLine($"{dots}{sharps}{dots}");
            }

            // Print the middle part
            for (int i = 0; i < n - 2; i++)
            {
                string leftDots = new string('.', 2 + 3 * i);
                string sharps = new string('#', 12 * n - 6 * i - 11);
                string rightDots = new string('.', 3 + 3 * i);
                Console.WriteLine($"|{leftDots}{sharps}{rightDots}");
            }

            // And of course: the bottom part
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write("|");
                }

                string leftDots = new string('.', 3 * n - 4);
                string sharps = new string('#', 6 * n + 1);
                string rightDots = new string('.', 3 * n - 3);
                Console.WriteLine($"{leftDots}{sharps}{rightDots}");
            }
        }
    }
}
