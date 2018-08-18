using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> queue = new Queue<long>();
            List<long> list = new List<long>();
            long n = long.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] current = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long amount = current[0];
                long distance = current[1];
                queue.Enqueue(amount - distance);
            }

            long[] arr = queue.ToArray();
            bool willRoll = false;
            long searchedIndex = 0;
            for (int i = 0; i < n; i++)
            {
                long total = 0;
                long counter = 0;
                int start = i;
                while (true)
                {
                    total += arr[start % n];
                    if (total <= 0)
                    {
                        break;
                    }
                    counter++;
                    if (counter > n - 1)
                    {
                        willRoll = true;
                        searchedIndex = i;
                        break;
                    }
                    start++;
                }
                if (willRoll)
                {
                    break;
                }
            }
            Console.WriteLine(searchedIndex);
        }
    }
}
