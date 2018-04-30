using System;
using System.Linq;

namespace _02._Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers = numbers.Where(x => x % 2 == 0).ToList();
            var average = numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
            

        }
    }
}
