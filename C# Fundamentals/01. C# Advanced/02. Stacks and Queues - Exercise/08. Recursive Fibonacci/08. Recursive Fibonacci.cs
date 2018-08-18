using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace _08._Recursive_Fibonacci
{
    public class Program
    {
        public static Dictionary<int, long> table = new Dictionary<int, long>();
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        public static long Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            if (!table.ContainsKey(n))
            {
                long first = Fibonacci(n - 1);
                long second = Fibonacci(n - 2);
                table.Add(n, first + second);
                table[n - 1] = first;
                table[n - 2] = second;
            }
            else
            {
                return table[n - 1] + table[n - 2];
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
