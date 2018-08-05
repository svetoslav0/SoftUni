using System;

namespace _06._Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool found = false;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
