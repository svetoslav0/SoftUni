using System;
using System.Linq;
namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = Console.ReadLine(); 
            string textTwo = Console.ReadLine();
            int[] massOne = textOne
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] massTwo = textTwo
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int lenOne = massOne.Length;
            int lenTwo = massTwo.Length;
            int maxLen = (lenOne > lenTwo) ? lenOne : lenTwo;
            int minLen = (lenOne < lenTwo) ? lenOne : lenTwo;
            int[] sum = new int[maxLen];
            for (int i = 0; i < maxLen; i++)
            {
                int testInt = i % minLen;
                sum[i] = (lenOne > lenTwo) ? (massOne[i] + massTwo[i%minLen]) : (massOne[i % minLen] + massTwo[i]);
            }
            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
