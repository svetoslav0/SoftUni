using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Fact(num);
        }

        static void Fact(int num)
        {
            BigInteger numFactorial = 1;
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                numFactorial *= i;
            }
            while (true)
            {
                if (numFactorial % 10 == 0)
                {
                    sum++;
                    numFactorial /= 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
    
}
