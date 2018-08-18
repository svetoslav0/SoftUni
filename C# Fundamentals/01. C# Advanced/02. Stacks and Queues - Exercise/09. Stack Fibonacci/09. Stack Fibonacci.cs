using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<long> stack = new Stack<long>();
        stack.Push(0);
        stack.Push(1);

        for (int i = 0; i < n; i++)
        {
            long first = stack.Pop();
            long second = stack.Peek();
            stack.Push(first);
            stack.Push(first + second);
        }
        stack.Pop();
        Console.WriteLine(stack.Peek());
    }
}
