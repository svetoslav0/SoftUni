using System;

namespace _15._Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int current = 2; current <= num; current++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Ceiling(Math.Sqrt(current)); divisor++)
                {
                    if (current % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (current == 2)
                {
                   isPrime = true;
                }
                Console.WriteLine($"{current} -> {isPrime}");
            }

        }
    }
}
