using System;

namespace _04._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number of the loops
            int n = int.Parse(Console.ReadLine());
            double points = 0.0;
            double group0to9 = 0, group10to19 = 0, group20to29 = 0, group30to39 = 0, group40to50 = 0, invalid = 0;

            // Distribute each number in the corresponding group
            for (int i = 0; i < n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    group0to9++;
                    points += 0.2 * currentNumber;
                }
                else if (currentNumber >= 10 && currentNumber <= 19)
                {
                    group10to19++;
                    points += 0.3 * currentNumber;
                }
                else if (currentNumber >= 20 && currentNumber <= 29)
                {
                    group20to29++;
                    points += 0.4 * currentNumber;
                }
                else if (currentNumber >= 30 && currentNumber <= 39)
                {
                    group30to39++;
                    points += 50;
                }
                else if (currentNumber >= 40 && currentNumber <= 50)
                {
                    group40to50++;
                    points += 100;
                }
                else
                {
                    invalid++;
                    points /= 2;
                }
            }

            // Print the total points and the percentages of the numbers
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {group0to9 / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {group10to19 / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {group20to29 / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {group30to39 / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {group40to50 / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid / n * 100:f2}%");
        }
    }
}
