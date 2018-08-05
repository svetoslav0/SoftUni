using System;

namespace _06._Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input numbers from the console
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            // Check if the current number is S and print the result
            for (int i = m; i >= n; i--)
            {
                if (i == s && i % 6 == 0)
                {
                    break;
                }
                if (i % 6 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
