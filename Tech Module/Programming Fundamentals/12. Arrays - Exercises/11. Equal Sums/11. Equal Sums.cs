using System;
using System.Linq;
namespace _11._Equal_Sums
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
            int len = numbers.Length;
            int leftSum = 0;
            int totalSum = 0;
            int index = 0;
            bool equalSum = false;
            for (int i = 0; i < len; i++)
            {
                totalSum += numbers[i];
            }
            for (int i = 0; i < len; i++)
            {
                if (leftSum == totalSum - (leftSum + numbers[i]))
                {
                    equalSum = true;
                    index = i;
                }
                leftSum += numbers[i];
            }
            string result = (equalSum) ? index.ToString() : "no";
            Console.WriteLine(result);
        }
    }
}
