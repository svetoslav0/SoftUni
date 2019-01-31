using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> squareNums = new List<double>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) % 1 == 0)
                {
                    squareNums.Add(numbers[i]);
                }
            }
            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
