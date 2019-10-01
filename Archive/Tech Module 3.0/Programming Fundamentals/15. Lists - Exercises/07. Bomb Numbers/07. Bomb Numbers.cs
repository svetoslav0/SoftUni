using System;
using System.Linq;
using System.Collections.Generic;
namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                  // 0  1 2  3  4 5  6 7
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  // 1 (2 2 -4- 2 2) 2 9
            int[] actions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();     // -4- 2
            int sumOfDetonated = 0;
            int totalSum = 0;
            foreach (var item in numbers)
            {
                totalSum += item;
            }
            for (int i = 0; i < actions[1]; i++)
            {                                                                              // 0 1 2  3 4  5  6 7  8 9 10 11
                numbers.Add(0);                                                            // 0 0 1 (2 2 -4- 2 2) 2 9 0  0
                numbers.Insert(0, 0);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == actions[0])
                {
                    for (int j = i - actions[1]; j <= i + actions[1]; j++)
                    {
                        sumOfDetonated += numbers[j];
                    }
                    for (int j = i - actions[1]; j < i + actions[1]; j++)
                    {
                        try
                        {
                        numbers.RemoveAt(j);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            Console.WriteLine(totalSum - sumOfDetonated);
        }
    }
}
