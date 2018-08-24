using System;
using System.Linq;

namespace _03._01._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }
               , StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[] sizes = new int[3];

            foreach (var num in numbers)
            {
                int reminder = Math.Abs(num % 3);
                sizes[reminder]++;
            }

            int[][] jagged = new int[3][];
            jagged[0] = new int[sizes[0]];
            jagged[1] = new int[sizes[1]];
            jagged[2] = new int[sizes[2]];

            int[] offset = new int[3];
            foreach (var num in numbers)
            {
                int reminder = Math.Abs(num % 3);
                jagged[reminder][offset[reminder]] = num;
                offset[reminder]++;
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
