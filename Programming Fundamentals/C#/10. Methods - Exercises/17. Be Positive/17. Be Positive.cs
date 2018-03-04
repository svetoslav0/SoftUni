using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            //string[] input = Console.ReadLine().Trim().Split(' ');
            int[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                numbers.Add(input[j]);
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else
                {
                    try
                    {
                        currentNum += numbers[j + 1];

                    }
                    catch (Exception)
                    {
                        break;
                    }

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    j++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}