using System;

namespace _06._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the two number that will combine and the magic number
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool combinationFound = false;

            // Loop and make the combinations
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    // Check if the sum is magic
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter + 1} ({i} + {j} = {magicNum})");
                        combinationFound = true;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
                // If the sum's found => stop the loops
                if (combinationFound)
                {
                    break;
                }
            }

            // If the magic sum in not found => print the total number of the combinations
            if (!combinationFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
