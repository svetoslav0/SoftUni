using System;
using System.Linq;
namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] nums = text.Split(' ').Select(int.Parse).ToArray();
            int length = nums.Length;
            int[] folded = new int[length/2];
            int[] leftSum = new int[length/4];
            int[] rightSum = new int[length/4];
            int[] middleSum = new int[length/2];
            int counter = 0;
            for (int i = 0; i < length/4; i++)
            {
                leftSum[i] = nums[i];
            }
            for (int i = length / 4; i < 3*length/4; i++)
            {
                middleSum[counter] = nums[i];
                counter++;
            }
            counter = 0;
            for (int i = 3 * length / 4; i < length; i++)
            {
                rightSum[counter] = nums[i];
                counter++;
            }
            leftSum = leftSum.Reverse().ToArray();
            rightSum = rightSum.Reverse().ToArray();
            for (int i = 0; i < length / 4; i++)
            {
                folded[i] = leftSum[i] + middleSum[i];
            }
            counter = 0;
            for (int i = length/4; i < length/2; i++)
            {
                folded[i] = rightSum[counter] + middleSum[i];
                counter++;
            }
            foreach (var item in folded)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
