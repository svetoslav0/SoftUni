using System;
using System.Numerics;

namespace _01._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bestValue = 0, bestSnow = 0, bestTime = 0, bestQuality = 0;
            for (int i = 0; i < n; i++)
            {
                BigInteger currentSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger currentTime = BigInteger.Parse(Console.ReadLine());
                BigInteger currentQuality = BigInteger.Parse(Console.ReadLine());

                BigInteger currentValue = Pow(currentSnow / currentTime, currentQuality);
                if (currentValue > bestValue)
                {
                    bestValue = currentValue;
                    bestTime = currentTime;
                    bestSnow = currentSnow;
                    bestQuality = currentQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }

        public static BigInteger Pow(BigInteger a, BigInteger x)
        {
            BigInteger result = 1;
            for (int i = 0; i < x; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
