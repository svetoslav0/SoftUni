using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string textNums = Console.ReadLine();
            List<int> numbers = textNums.Split(' ').Select(int.Parse).ToList();
            int currentLength = 1;
            int currentPosition = 0;
            int bestLength = 1;
            int bestPosition = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestPosition = currentPosition;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentPosition = i;
                }
            }
            for (int i = bestPosition; i < bestLength + bestPosition; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
