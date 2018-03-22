using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            result.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", result));
                    break;
                }
                else if (input[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            result.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", result));
                    break;
                }
                switch (input[0])
                {
                    case "Delete":
                        int element = int.Parse(input[1]);
                        numbers.RemoveAll(x => x == element);
                        break;
                    case "Insert":
                        element = int.Parse(input[1]);
                        int position = int.Parse(input[2]);
                        numbers.Insert(position, element);
                        break;
                }
            }
        }
    }
}
