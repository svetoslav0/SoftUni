using System;

namespace _06._Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maximum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool finished = false;

            // Loop the two numbers and make different combinations between them
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.Write($"<{i}-{j}>");
                    counter++;
                    // If the maximum is reached => the program stops the inner loop and 'tells' the outer to stop
                    if (counter >= maximum)
                    {
                        finished = true;
                        break;
                    }
                }
                if (finished)
                {
                    break;
                }
            }
        }
    }
}
