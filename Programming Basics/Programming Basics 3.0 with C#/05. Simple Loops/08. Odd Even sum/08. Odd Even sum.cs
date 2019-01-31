using System;

namespace _08._Odd_Even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    num = int.Parse(Console.ReadLine());
                    sum1 += num;
                }
                else
                {
                    num = int.Parse(Console.ReadLine());
                    sum2 += num;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum2 - sum1)}");
            }
        }
    }
}
