using System;
using System.Linq;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte[] bestDNA = new byte[n - 1];
            int bestIndex = 0;
            int bestLength = 0;
            int bestSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentSequence = input.Split('!',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bestCurrentIndex = 0;
                int bestCurrentLength = 0;
                int bestCurrentSum = 0;
                foreach (var item in currentSequence)
                {
                    if (item == 1)
                    {
                        bestCurrentLength = 1;
                    }
                }

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == 1 && currentSequence[i + 1] == 1)
                    {
                        bestCurrentIndex = i;
                        bestCurrentLength++;
                    }
                    else
                    {
                        bestCurrentLength = 1;
                    }
                    if (currentSequence[i] == 1)
                    {
                        bestCurrentSum++;
                    }
                }
                if (bestCurrentIndex < bestIndex)
                {
                    bestIndex = bestCurrentIndex;
                }
                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                }
                if (bestCurrentSum > bestSum)
                {
                    bestSum = bestCurrentSum;
                }
            }
            Console.WriteLine(bestIndex);
            Console.WriteLine(bestLength);
            Console.WriteLine(bestSum);

        }
    }
}
