using System;
using System.Linq;
namespace _07._Max_Seq_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int[] numbers = text
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int length = numbers.Length;
            int bestLen = 1, bestPos = 0;
            for (int i = 0; i < length - 1; i++)
            {
                int len = 1, pos = 0;
                for (int j = i; j < length - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        len++;
                        pos = j;
                    }
                    else
                    {
                        break;
                    }
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestPos = pos;
                }
            }
            for (int i = bestPos - bestLen + 2; i <= bestPos + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
