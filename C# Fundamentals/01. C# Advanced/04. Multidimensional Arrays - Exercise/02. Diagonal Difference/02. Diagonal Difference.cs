using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] currentRow = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = currentRow;
            }

            int primarySum = 0, secondarySum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                primarySum += matrix[i][i];
                secondarySum += matrix[i][size - i - 1];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
