using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i] == ')')
                {
                    int openingIndex = stack.Pop();
                    int closingIndex = i;
                    Console.WriteLine(input.Substring(openingIndex, closingIndex - openingIndex + 1));
                }
            }
        }
    }
}
