using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {                                       //123 234 12 -> 774      // 321 + 432 + 21 = 774
            string text = Console.ReadLine();
            List<int> numbers = text.Split(' ').Select(int.Parse).ToList();
            List<int> reversedNums = new List<int>();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> tempList = new List<int>();
                int tempNum = numbers[i];
                int reversedNum = 0;
                while (tempNum > 0)
                {
                    tempList.Add(tempNum % 10);
                    tempNum /= 10;
                }
                foreach (var item in tempList)
                {
                    reversedNum = reversedNum * 10 + item;
                }
                reversedNums.Add(reversedNum);
            }
            foreach (var item in reversedNums)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
