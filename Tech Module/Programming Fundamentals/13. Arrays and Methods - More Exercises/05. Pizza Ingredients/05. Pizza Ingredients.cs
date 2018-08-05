using System;
using System.Collections.Generic;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            List<string> ingadients = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (ingadients.Count >= 10)
                {
                    break;
                }
                if (input[i].Length == n)
                {
                    ingadients.Add(input[i]);
                }
            }
            for (int i = 0; i < ingadients.Count; i++)
            {
                Console.WriteLine($"Adding {ingadients[i]}.");
            }
            Console.WriteLine($"Made pizza with total of {ingadients.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingadients)}.");

        }
    }
}
