using System;

namespace _05._Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number from the console
            int n = int.Parse(Console.ReadLine());

            // Print the top 
            string tildes = new string('~', n - 2);
            string dots = new string('.', 2 * n + 1);
            Console.WriteLine($"+{tildes}+{dots}");

            for (int i = 0; i < 2 * n + 1; i++)
            {
                string leftDots = new string('.', i);
                string rightDots = new string('.', 2 * n - i);
                Console.WriteLine($@"|{leftDots}\{tildes}\{rightDots}");
            }

            // Print the bottom
            for (int i = 0; i < 2 * n + 1; i++)
            {
                string leftDots = new string('.', i);
                string rightDots = new string('.', 2 * n - i);
                Console.WriteLine($@"{leftDots}\{rightDots}|{tildes}|");
            }

            Console.WriteLine($"{dots}+{tildes}+");
        }
    }
}
