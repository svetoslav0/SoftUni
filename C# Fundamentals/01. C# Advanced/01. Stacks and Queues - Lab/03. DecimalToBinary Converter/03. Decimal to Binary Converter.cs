using System;
using System.Collections.Generic;

namespace _03._DecimalToBinary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            do
            {
                int reminder = num % 2;
                num /= 2;
                stack.Push(reminder);
            }while (num > 0);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
