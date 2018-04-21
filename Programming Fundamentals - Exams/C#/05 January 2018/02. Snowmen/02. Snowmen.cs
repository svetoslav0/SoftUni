using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();                              // length = 7 !!!
            while (true)                                // 0  1  2 3 4 5 6 <- indexes
            {                                           // 25 31 6 9 2 4 7 
                int length = input.Count;
                if (length <= 1)
                {
                    break;
                }
                List<int> indexesToRemove = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    if (indexesToRemove.Contains(i))
                    {
                        continue;
                    }
                    int currentAttackerIndex = i;
                    int currentTargetIndex = input[i] % length;
                    int diff = Math.Abs(currentAttackerIndex - currentTargetIndex);
                    if (diff == 0)
                    {
                        if (!indexesToRemove.Contains(currentTargetIndex))
                        {
                            indexesToRemove.Add(currentTargetIndex);
                        }
                        Console.WriteLine($"{currentAttackerIndex} performed harakiri");
                    }
                    else if (diff % 2 == 0)
                    {
                        if (!indexesToRemove.Contains(currentTargetIndex))
                        {
                            indexesToRemove.Add(currentTargetIndex);
                        }
                        Console.WriteLine("{0} x {1} -> {0} wins", currentAttackerIndex, currentTargetIndex);
                    }
                    else if (diff % 2 != 0)
                    {
                        if (!indexesToRemove.Contains(currentAttackerIndex))
                        {
                            indexesToRemove.Add(currentAttackerIndex);
                        }
                        Console.WriteLine("{0} x {1} -> {1} wins", currentAttackerIndex, currentTargetIndex);
                    }
                    if (input.Count - indexesToRemove.Count == 1)
                    {
                        break;
                    }
                }
                indexesToRemove.Sort();
                indexesToRemove.Reverse();
                for (int i = 0; i < indexesToRemove.Count; i++)
                {
                    input.RemoveAt(indexesToRemove[i]);
                }
                indexesToRemove.Clear();

            }

        }
    }
}
