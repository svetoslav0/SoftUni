using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {'|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
            }
            List<List<string>> lists = new List<List<string>>();
            List<string> innerList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                innerList.Add(input[i]);
            }
            innerList.Reverse();
            lists.Add(innerList);
            foreach (var list in lists)
            {
                foreach (var innerItem in innerList)
                {
                    Console.Write(innerItem + " ");
                }
            }
            Console.WriteLine();

        }
    }
}
