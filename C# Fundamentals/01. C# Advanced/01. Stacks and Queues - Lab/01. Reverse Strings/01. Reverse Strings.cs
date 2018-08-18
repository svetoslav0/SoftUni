using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the console
            string inputString = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            // Push the string's charecters into a stack
            foreach (var ch in inputString)
            {
                stack.Push(ch);
            }

            // Pop() and print the stack's elements one by one
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
