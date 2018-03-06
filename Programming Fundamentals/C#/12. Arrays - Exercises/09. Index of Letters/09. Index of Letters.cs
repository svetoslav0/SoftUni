using System;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            char[] symbols = text.ToCharArray();
            foreach (char item in symbols)
            {
                Console.WriteLine($"{item} -> {item - 97}");
            }
        }
    }
}
