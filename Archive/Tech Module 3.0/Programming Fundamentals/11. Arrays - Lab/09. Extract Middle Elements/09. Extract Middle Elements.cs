using System;
using System.Linq;
namespace _09._Extract_Middle_Elements
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
            string middleNums = "";
            if (len == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (len % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[len / 2 - 1]}, {numbers[len / 2]} }}");

            }
            else if (len % 2 == 1)
            {
                Console.WriteLine($"{{ {numbers[len / 2 - 1]}, {numbers[len / 2]}, {numbers[len / 2 + 1]} }}");

            }

        }
    }
}
