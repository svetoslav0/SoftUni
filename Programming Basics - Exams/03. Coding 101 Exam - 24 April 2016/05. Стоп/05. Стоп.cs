using System;

namespace _05._Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Drawing top part
            string upperDots = new string('.', n + 1);
            string upperUnderscore = new string('_', 2 * n + 1);
            Console.WriteLine($"{upperDots}{upperUnderscore}{upperDots}");
            for (int i = 0; i < n; i++)
            {
                string dots = new string('.', n - i);
                string underscore = new string('_', 2 * (n + i) - 1);
                Console.WriteLine($@"{dots}//{underscore}\\{dots}");
            }

            // Drawing middle part
            string middleUnderscore = new string('_', 2 * n - 3);
            Console.WriteLine($@"//{middleUnderscore}STOP!{middleUnderscore}\\");

            // Drawing bottom part
            for (int i = 0; i < n; i++)
            {
                string bottomDots = new string('.', i);
                string bottomUnderscore = new string('_', 2 * (2 * n - i) - 1);
                Console.WriteLine($@"{bottomDots}\\{bottomUnderscore}//{bottomDots}");
            }
        }
    }
}
