using System;

namespace _04._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = new long[i + 1];
                jagged[i][0] = 1;
                long lastElement = jagged[i].Length - 1;
                jagged[i][lastElement] = 1;
                if (i >= 2)
                {
                    for (int j = 1; j < i; j++)
                    {
                        jagged[i][j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
                    }
                }
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
