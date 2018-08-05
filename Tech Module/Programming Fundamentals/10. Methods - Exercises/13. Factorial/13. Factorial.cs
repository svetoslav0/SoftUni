using System;
using System.Numerics;

namespace _13._Factorial
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
            for (int i = 1; i <= num; i++)
            {
                numFactorial *= i;
            }
            Console.WriteLine(numFactorial);
        }
    }
}
