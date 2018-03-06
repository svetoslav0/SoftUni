using System;
using System.Linq;
namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');
            string word1 = string.Join("", array1);
            string word2 = string.Join("", array2);
            if (word1.CompareTo(word2) == 1)
            {
                Console.WriteLine(word2);
                Console.WriteLine(word1);
            }
            else
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }

        }
    }
}
