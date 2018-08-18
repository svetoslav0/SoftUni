using System;
using System.Collections.Generic;

namespace _02._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); // 2 + 5 + 10 - 2 - 1 = 14
            var stack = new Stack<string>();
            stack.Push("+");

            foreach (var element in input)
            {
                stack.Push(element);
            }

            while (stack.Count > 2)
            {
                int num1 = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int num2 = int.Parse(stack.Pop());
                int current = 0;
                
                string next = stack.Peek();
                if (next == "+")
                {
                    switch (operand)
                    {
                        case "+":
                            current = num1 + num2;
                            break;
                        case "-":
                            current = num2 - num1;
                            break;
                    }
                }
                else
                {
                    switch (operand)         // 2 + 5 + 10 - 2 + 1
                    {
                        case "+":
                            current = num2 - num1;
                            break;
                        case "-":
                            current = num1 + num2;
                            break;
                    }
                }

                stack.Push(current.ToString());
            }

            int result = int.Parse(stack.Pop());
            Console.WriteLine(result);
        }
    }
}
