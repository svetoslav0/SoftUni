using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maximums = new Stack<int>();
            maximums.Push(int.MinValue);
            
            // case 1: add element "1 x"
            // case 2: delete element
            // case 3: print the max

            for (int i = 0; i < n; i++)
            {
                string[] op = Console.ReadLine().Split();

                if (op[0] == "1")
                {
                    int numToAdd = int.Parse(op[1]);
                    if (numToAdd > maximums.Peek())
                    {
                        maximums.Push(numToAdd);
                    }
                    stack.Push(numToAdd);

                }
                else if (op[0] == "2")
                {
                    if (maximums.Peek() == stack.Peek())
                    {
                        maximums.Pop();
                    }
                    stack.Pop();
                }
                else if (op[0] == "3")
                {
                    Console.WriteLine(maximums.Peek());
                }
            }
        }
    }
}
