using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _07._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>();
            bool balanced = false;

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    char opening = stack.Pop();
                    if (!((opening == '(' && input[i] == ')') || (opening == '[' && input[i] == ']') || (opening == '{' && input[i] == '}')))
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
