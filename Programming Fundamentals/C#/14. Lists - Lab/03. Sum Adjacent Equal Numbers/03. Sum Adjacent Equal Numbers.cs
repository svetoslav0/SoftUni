using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    numbers[i-1] *= 2;
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
