using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input information from the console
            int[] operators = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numsToPush = operators[0];
            int numsToPop = operators[1];
            int numToFind = operators[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            // Push the numbers into a stack
            for (int i = 0; i < numsToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            // Pop S numbers from the stack
            for (int i = 0; i < numsToPop; i++)
            {
                stack.Pop();
            }

            int smallest = int.MaxValue;
            if (stack.Contains(numToFind))
            {
                Console.WriteLine($"true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                foreach (var num in stack.ToList())
                {
                    int current = stack.Pop();
                    if (current < smallest)
                    {
                        smallest = current;
                    }
                }
                Console.WriteLine(smallest);
            }



        }
    }
}
