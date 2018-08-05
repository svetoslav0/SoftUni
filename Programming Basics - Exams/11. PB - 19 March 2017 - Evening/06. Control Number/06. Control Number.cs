using System;

namespace _06._Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the conosle
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            int movesCounter = 0;
            int sum = 0;
            bool done = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    movesCounter++;
                    sum += 2 * i + 3 * j;
                    if (sum >= controlNum)
                    {
                        done = true;
                        break;
                    }
                }
                if (done)
                {
                    break;
                }
            }

            Console.WriteLine($"{movesCounter} moves");
            if (done)
            {
                Console.WriteLine($"Score: {sum} >= {controlNum}");
            }
        }
    }
}
