using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMulitplyOfEvenByOdd(Math.Abs(number)));
        }
        static int GetMulitplyOfEvenByOdd(int num)
        {
            int sumOfOdds = GetSumOfOdds(num);
            int sumOfEvens = GetSumOfEvens(num);
            return sumOfEvens * sumOfOdds;
        }
        static int GetSumOfEvens(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOdds(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

    }
}
