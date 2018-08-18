using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> indexesToRemove = new Stack<int>();  // 6 5 8 4 7 10 9 
            bool keepGoing = true;
            int counter = 0;

            while(keepGoing)
            {
                for (int i = 0; i < plants.Count - 1; i++)
                {
                    if (plants[i] < plants[i + 1])
                    {
                        indexesToRemove.Push(i + 1);
                    }
                }

                if (indexesToRemove.Count == 0)
                {
                    keepGoing = false;
                    break;
                }

                counter++;

                while (indexesToRemove.Count > 0)
                {
                    int currentIndex = indexesToRemove.Pop();
                    plants.RemoveAt(currentIndex);
                }
            }
            Console.WriteLine(counter);
        }
    }
}
