using System;
using System.Linq;
using System.Collections.Generic;
namespace _5._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = text.Split(' ').Select(int.Parse).ToList();
            string actionText;
            while (true)
            {
                actionText = Console.ReadLine();
                int contains = -1;
                List<string> actions = actionText.Split(' ').ToList();
                if (actions[0] == "print")
                {
                    break;
                }
                else if (actions[0] == "add")
                {
                    numbers.Insert(int.Parse(actions[1]), int.Parse(actions[2]));
                }
                else if (actions[0] == "addMany")
                {
                    for (int i = actions.Count - 1; i > 1; i--)
                    {
                        numbers.Insert(int.Parse(actions[1]), int.Parse(actions[i]));
                    }
                }
                else if (actions[0] == "contains")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(actions[1]))
                        {
                            contains = i;
                            Console.WriteLine(contains);
                            break;
                        }
                    }
                    if (contains == -1)
                    {
                        Console.WriteLine(contains);
                    }
                }
                else if (actions[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(actions[1]));
                }
                else if (actions[0] == "shift")
                {
                    List<int> shiftNums = new List<int>(new int[numbers.Count]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        shiftNums[i] = numbers[(i + int.Parse(actions[1])) % numbers.Count];
                    }
                    for (int i = 0; i < numbers.Count; i++)                                    // actions
                    {                                                                          // add <index> <element> - add single element
                        numbers[i] = shiftNums[i];                                             // addMany <index> <el1> <el2> ...
                    }                                                                          // containt <element> - ? index : (-1)
                                                                                               // remove <index>
                }                                                                              // shift <positions> - to the left
                else if (actions[0] == "sumPairs")                                             // sumPairs
                {
                    if (numbers.Count % 2 == 0)
                    {
                        List<int> halfNums = new List<int>(new int[numbers.Count / 2]);
                        for (int i = 0, j = 0; i < halfNums.Count; i += 2, j += 2)
                        {
                            halfNums[j] = numbers[i] + numbers[i + 1];
                        }
                        for (int i = 0; i < numbers.Count / 2; i++)
                        {
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] = halfNums[i];
                        }
                    }
                    else
                    {
                        List<int> halfNums = new List<int>(new int[numbers.Count / 2 + 1]);
                        halfNums[numbers.Count] = 0;
                        for (int i = 0, j = 0; i < halfNums.Count; i += 2, j += 2)
                        {
                            halfNums[j] = numbers[i] + numbers[i + 1];
                        }
                        for (int i = 0; i < numbers.Count / 2; i++)
                        {
                            numbers.RemoveAt(numbers.Count);
                        }
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] = halfNums[i];
                        }
                    }

                }
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");


            }
        }
    }
}
