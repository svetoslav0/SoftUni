using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textNumbers = Console.ReadLine();
            List<int> numbers = textNumbers
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> positiveNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                if (currentNum > 0)
                {
                    positiveNums.Add(currentNum);
                }
            }
            positiveNums.Reverse();
            if (positiveNums.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(String.Join(" ", positiveNums));

        }
    }
}