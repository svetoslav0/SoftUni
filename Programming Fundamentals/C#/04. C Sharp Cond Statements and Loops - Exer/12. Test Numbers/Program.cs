using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= max)
                    {
                        break;
                    }
                    sum += 3 * i * j;
                    count++;
                }
            }
            Console.WriteLine($"{count} combinations");
            if (sum >= max)
            {
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
