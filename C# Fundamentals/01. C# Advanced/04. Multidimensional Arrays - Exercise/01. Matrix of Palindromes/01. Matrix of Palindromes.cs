using System;
using System.Linq;

namespace _01._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 6
            // aaa aba aca ada aea afa
            // bbb bcb bdb beb bfb bgb
            // ccc cdc cec cfc cgc chc
            // ddd ded dfd dgd dhd did

            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[][] matrix = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                string[] currentRow = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    string currentWord = alphabet[i].ToString() + alphabet[i + j].ToString() + alphabet[i].ToString();
                    currentRow[j] = currentWord;
                }
                matrix[i] = currentRow;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
