using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ops = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToAdd = ops[0];
            int elementsToRemove = ops[1];
            int numToFind = ops[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numToFind))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
