using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[n - 1];

            int bestLength = 1, bestIndex = Int32.MaxValue, bestSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int bestCurrentLength = 1, currentLength = 1, bestCurrentIndex = 0, currentIndex = 0, currentSum = 0;
                int[] currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        currentSum++;
                    }
                }
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == 1 && currentSequence[i+1] == 1)
                    {
                        currentLength++;
                        currentIndex = i;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                    
                    if(currentLength > bestCurrentLength)
                    {
                        bestCurrentLength = currentLength;
                        bestCurrentIndex = currentIndex;
                    }
                    
                }
                bestCurrentIndex += 2 - bestCurrentLength;

                if (bestSum < currentSum)
                {
                    bestSum = currentSum;
                }
                if (bestIndex > bestCurrentIndex)
                {
                    bestIndex = bestCurrentIndex;
                }

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestDNA = currentSequence;
                }
                else if(bestCurrentLength == bestLength && bestCurrentIndex < bestIndex)
                {
                    bestIndex = bestCurrentIndex;
                    bestDNA = currentSequence;
                }
                else if (bestCurrentLength == bestLength && bestCurrentIndex < bestIndex && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestDNA = currentSequence;
                }
                
                
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",bestDNA));

        }
    }
}
