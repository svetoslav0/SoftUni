using System;
using System.Collections.Generic;

namespace _07._Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            List<long> primeNums = FillListWithPrimeNums(start,end);
            Console.WriteLine(string.Join(", ", primeNums));
        }

        static List<long> FillListWithPrimeNums(long start, long end)
        {
            var primeNums = new List<long>();
            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNums.Add(i);
                }
            }
            return primeNums;
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
