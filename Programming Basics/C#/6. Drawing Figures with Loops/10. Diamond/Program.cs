using System;

namespace _10._Diamond
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine($"{new string('-', (n - 1) / 2 - i)}*{new string('-', i * 2)}*{new string('-', (n - 1) / 2 - i)}");
                }
                for (int i = n / 2-1; i > 0; i--)
                {
                    Console.WriteLine($"{new string('-', n/2-i)}*{new string('-', i * 2-2)}*{new string('-', n / 2 - i)}");
                }
            }
            else
            {
                Console.WriteLine($"{new string('-',n/2)}*{new string('-', n / 2)}");
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine($"{new string('-', (n - 3) / 2 - i)}*{new string('-', 2 * i + 1)}*{new string('-', (n - 3) / 2 - i)}");
                }
                for (int i = n/2-1; i > 0; i--)
                {
                    Console.WriteLine($"{new string('-', n/2-i)}*{new string('-', 2 * i - 1)}*{new string('-', n/2-i)}");
                }
                if (n>1)
                {
                    Console.WriteLine($"{new string('-', n / 2)}*{new string('-', n / 2)}");

                }

            }

        }
        }
    }
