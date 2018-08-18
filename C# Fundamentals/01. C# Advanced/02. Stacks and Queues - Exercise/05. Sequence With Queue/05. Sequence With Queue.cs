using System;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            List<long> list = new List<long>();
            long counter = 0, first = n + 1, second = 2 * n + 1, third = n + 2;
            int idx = 1;
            queue.Enqueue(n);
            queue.Enqueue(first);
            queue.Enqueue(second);
            queue.Enqueue(third);
            list.Add(n);
            list.Add(first);
            list.Add(second);
            list.Add(third);

            while (counter <= 50)
            {
                first = list[idx] + 1;
                second = 2 * list[idx] + 1;
                third = list[idx] + 2;
                queue.Enqueue(first);
                queue.Enqueue(second);
                queue.Enqueue(third);
                list.Add(first);
                list.Add(second);
                list.Add(third);

                counter += 3;
                idx++;
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{queue.Dequeue()} ");
            }
            Console.WriteLine();
        }
    }
}
