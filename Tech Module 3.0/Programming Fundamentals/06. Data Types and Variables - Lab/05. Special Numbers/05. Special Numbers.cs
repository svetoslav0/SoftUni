using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int sum, p;
            for (int i = 1; i <= n; i++)
            {
                isSpecial = false;
                sum = 0;
                p = i;
                while (true)
                {
                    sum += p % 10;
                    p /= 10;
                    if (p == 0)
                    {
                        break;
                    }
                }
                if (sum == 5 || sum == 7 || sum ==11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
