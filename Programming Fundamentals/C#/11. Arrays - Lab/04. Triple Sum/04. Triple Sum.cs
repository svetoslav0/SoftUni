using System;
using System.Linq;
namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numsText = Console.ReadLine();
            long[] numbers = numsText.Split(' ').Select(long.Parse).ToArray();
            bool sumFound = false;
            for (long firstNumber = 0; firstNumber < numbers.Length - 1; firstNumber++)
            {
                for (long secondNumber = firstNumber + 1; secondNumber <= numbers.Length - 1; secondNumber++)
                {
                    long currentSum = numbers[firstNumber] + numbers[secondNumber];
                    for (long sumNumbers = 0; sumNumbers <= numbers.Length - 1; sumNumbers++)
                    {
                        if (currentSum == numbers[sumNumbers] && numbers[secondNumber] >= 0)
                        {
                            Console.WriteLine($"{numbers[firstNumber]} + {numbers[secondNumber]} == {numbers[sumNumbers]}");
                            sumFound = true;
                            break;
                        }
                        else if (currentSum == numbers[sumNumbers] && numbers[secondNumber] < 0)
                        {
                            Console.WriteLine($"{numbers[firstNumber]} - {Math.Abs(numbers[secondNumber])} == {numbers[sumNumbers]}");
                            sumFound = true;
                            break;
                        }
                    }
                }
            }
            if (sumFound == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
