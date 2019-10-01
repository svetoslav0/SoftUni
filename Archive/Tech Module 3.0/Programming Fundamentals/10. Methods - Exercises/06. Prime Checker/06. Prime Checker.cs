using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long num)
        {
            bool isPrime = true;
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                double divided = num % i;
                if (divided == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (num < 2)
            {
                isPrime = false;
            }
            return isPrime;
        }
    }
}
