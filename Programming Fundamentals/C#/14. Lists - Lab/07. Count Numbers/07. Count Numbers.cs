using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] counter = new int[1001];
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < counter.Length; j++)
                {
                    if (numbers[i] == j)
                    {
                        counter[j]++;
                    }
                }
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counter[i]}");
                }
            }
        }
    }
}
