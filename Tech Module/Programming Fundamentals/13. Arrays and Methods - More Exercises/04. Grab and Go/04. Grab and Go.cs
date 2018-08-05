using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int numToFind = int.Parse(Console.ReadLine());
            int foundNum = Array.LastIndexOf(numbers, numToFind);
            long sum = 0;
            if (foundNum != -1)
            {
                for (int i = 0; i < foundNum; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine($"No occurrences were found!");
            }
        }
    }
}
