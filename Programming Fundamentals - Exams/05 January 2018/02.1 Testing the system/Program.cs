using System;
using System.Linq;

namespace _02._1_Testing_the_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = "text";
            if (input[0] < 10)
            {
                input[0] = int.Parse(text);
            }
            else
            {
                Console.WriteLine("Nope...");
            }
        }
    }
}
