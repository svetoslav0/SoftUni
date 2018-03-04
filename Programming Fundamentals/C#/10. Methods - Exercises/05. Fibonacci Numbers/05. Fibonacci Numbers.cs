using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(num));
        }

        static long Fib(int num)
        {
            long result = 0;
            long previous = 0;
            long current = 1;
            for (int i = 0; i < num; i++)
            {
                result = current + previous;
                previous = current;
                current = result;
            }
            if (num == 0)
            {
                result = 1;
            }
            return result;
        }
    }
}
