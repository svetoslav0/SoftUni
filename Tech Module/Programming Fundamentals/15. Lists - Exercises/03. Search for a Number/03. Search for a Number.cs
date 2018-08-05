using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = text.Split(' ').Select(int.Parse).ToList();
            List<int> sample = new List<int>();
            string textActions = Console.ReadLine(); // [0] = nums to take from Left to right
            int[] actions = textActions              // [1] = nums to delete from the sample(L->R)
                .Split(' ')                          // [2] = num to search after [1]
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < actions[0]; i++)
            {
                sample.Add(numbers[i]);
            }
            for (int i = 0; i < actions[1]; i++)
            {
                sample.RemoveAt(0);
            }
            bool isFound = false;
            for (int i = 0; i < sample.Count; i++)
            {
                if (sample[i] == actions[2])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
