using System;

namespace _09._House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write($"{new string('-', (n - 1) / 2 - i)}");
                if (n%2==0)
                {
                    Console.Write($"{new string('*',(i+1)*2)}");
                }
                else
                {
                    Console.Write($"{new string('*', i*2+1)}");

                }

                Console.WriteLine($"{new string('-', (n - 1) / 2 - i)}");
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine($"|{new string('*',n-2)}|");
            }
        }
    }
}
