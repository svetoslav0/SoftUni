using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int totalLength = input.Length - 1;
            int totalSum = input[0];
            for (int i = 0; i < totalLength; i++)
            {
                int[] nextRun = new int[input.Length - 1];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    nextRun[j] = input[j] + input[j + 1];
                }
                input = nextRun;
                totalSum = input[0];
            }
            Console.WriteLine(totalSum);

        }
    }
}
