using System;
using System.Linq;
using System.Diagnostics;
namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int diff = int.Parse(Console.ReadLine());
            int[] nums = text
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int len = nums.Length;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (Math.Abs(nums[i] - nums [j]) == diff)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
