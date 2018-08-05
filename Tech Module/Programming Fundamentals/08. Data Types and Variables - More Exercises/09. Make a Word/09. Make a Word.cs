using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string current;
            string word = "";
            for (int i = 0; i < n; i++)
            {
                current = Console.ReadLine();
                word += current;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
