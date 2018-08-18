using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            if (input.Length > 0)
            {
                int[] numbers = input.Split().Select(int.Parse).ToArray();
                Stack<int> stack = new Stack<int>();

                foreach (var num in numbers)
                {
                    stack.Push(num);
                }

                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop() + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
