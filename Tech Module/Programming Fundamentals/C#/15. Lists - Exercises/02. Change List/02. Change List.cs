using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = text.Split(' ').Select(int.Parse).ToList();
            string command = " ";
            while (true)
            {
                command = Console.ReadLine();
                if (command == "Odd")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 1)
                        {
                            Console.Write(item + " ");
                        }
                    }
                    break;
                }
                if (command == "Even")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            Console.Write(item + " ");
                        }
                    }
                    break;
                }
                List<string> action = command.Split(' ').ToList();
                if (action[0] == "Delete")
                {
                    int element = int.Parse(action[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(element);
                        }
                    }
                }
                else if (action[0] == "Insert")
                {
                    int element = int.Parse(action[1]);
                    int position = int.Parse(action[2]);
                    numbers.Insert(position, element);
                }
            }
            Console.WriteLine();
        }
    }
}
