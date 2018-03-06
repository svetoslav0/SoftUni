using System;
using System.Linq;
namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                if (IsPrime(i) == true)
                {
                    for (int j = 2; j < primes.Length; j++)
                    {
                        if (i * j >= primes.Length)
                        {
                            break;
                        }
                        primes[i * j] = false;
                    }
                }

            }
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
