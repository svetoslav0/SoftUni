using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static Stack<string> globalStack = new Stack<string>();

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            int command = int.Parse(input.Substring(0,1));

            switch (command)
            {
                case 1:
                    string arg = input.Substring(2, input.Length - 2);
                    globalStack.Push(arg);
                    break;
                case 2:
                    arg = input.Substring(2, input.Length - 2);
                    globalStack.Push(arg);
                    break;
                case 3:
                    arg = input.Substring(2, input.Length - 2);
                    ShowElement(arg);
                    break;
                case 4:
                    globalStack.Pop();
                    break;
            }

        }
    }
    

    public static void ShowElement(string arg)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> helperStack = new Stack<string>(globalStack);
        StringBuilder builder = new StringBuilder();
        int index = int.Parse(arg);

        while (helperStack.Count > 0)
        {
            queue.Enqueue(helperStack.Pop());
        }

        while (queue.Count > 0)
        {
            if (int.TryParse(queue.Peek(), out int num))
            {
                builder.Length -= num;
                queue.Dequeue();
            }
            else
            {
                builder.Append(queue.Dequeue());
            }
        }
        
        Console.WriteLine(builder[index - 1]);
    }
}
