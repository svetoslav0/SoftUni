using System;
using System.Linq;

namespace _09._Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = numbers.Length;
            int index = 0;
            int sum = numbers[0];
            while (true)
            {
                int currentNumber = numbers[index];        // 4 1 7 8 3 5
                if (index + currentNumber < length)       // _-------^
                {
                    index += currentNumber;               // 4 1 7 8 3 5
                    sum += numbers[index];                // 0 1 2 3 4 5
                }                                         //   ^-----_
                else if (index - currentNumber > 0)
                {
                    index -= currentNumber;
                    sum += numbers[index];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
