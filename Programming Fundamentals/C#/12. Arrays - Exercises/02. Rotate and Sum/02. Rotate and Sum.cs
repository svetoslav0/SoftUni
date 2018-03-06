using System;
using System.Linq;
namespace _02._Rotate_and_Sum
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
            int rotations = int.Parse(Console.ReadLine());
            int length = numbers.Length;
            int[] sum = new int[length];
            int[] temp = new int[length];
            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    temp[(j + 1) % length] = numbers[j % length];
                }
                for (int j = 0; j < length; j++)
                {
                    numbers[j] = temp[j];
                    sum[j] += temp[j];
                }
            }
            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
