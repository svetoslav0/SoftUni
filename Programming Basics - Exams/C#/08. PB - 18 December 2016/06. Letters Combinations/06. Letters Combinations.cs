using System;

namespace _06._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            // Print the combinations with skips
            int counter = 0;
            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        // Print the current combination if it does not contains the skip char
                        if (i != skip && j != skip && k != skip)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
