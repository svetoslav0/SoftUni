using System;

namespace _12._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double a = 0.0;
            double b = 0.0;
            double sum1 = 0.0;
            double sum2 = 0.0;
            double sum3 = 0.0;
            double maxDiff = 0.0;
            a = double.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum1 = a + b;
            for (int i = 0; i < n-1; i++)
            {
                a = double.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                sum2 = a + b;
                if (Math.Abs(sum1 - sum2) > maxDiff)
                {
                    maxDiff = Math.Abs(sum1 - sum2);
                }
                sum1 = sum2;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
