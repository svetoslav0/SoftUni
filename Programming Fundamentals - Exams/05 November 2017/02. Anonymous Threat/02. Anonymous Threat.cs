using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "3:1")
                {
                    break;
                }
                string currentCommand = commands[0];
                if (currentCommand == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (endIndex > list.Count - 1)
                    {
                        endIndex = list.Count - 1;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > list.Count - 1)
                    {
                        startIndex = list.Count - 1;
                    }
                    string merged = "";
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged += list[i];
                    }
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        list.RemoveAt(startIndex);
                    }
                    list[startIndex] = merged;
                }
                else if(currentCommand == "divide")                     // words: Pesho Ivan Gosho Mihail
                {
                    int index = int.Parse(commands[1]);                 // 3
                    int partitions = int.Parse(commands[2]);            // 3
                    if (partitions == 0)
                    {
                        continue;
                    }
                    List<string> currentList = new List<string>();      // Should be: [Mi, ha, il]
                    string currentWord = list[index];                   // Mihail
                    if (currentWord.Length % partitions == 0)
                    {
                        int length = currentWord.Length / partitions;   // 2
                        int startIndex = 0;                             // 0
                        int endIndex = length;                          // 2
                        for (int i = 0; i < partitions; i++)
                        {                                                                  // 01   23   45
                            currentList.Add(currentWord.Substring(startIndex, length));  // Mi   ha   il
                            startIndex += endIndex;
                        }
                        currentList.Reverse();
                        list.RemoveAt(index);
                        for (int i = 0; i < currentList.Count; i++)
                        {
                            list.Insert(index, currentList[i]);
                        }

                    }                                           // currentWord = Svetoslav, len = 9
                    else                                        // divide by 4: Sv et os lav
                    {
                        int length = currentWord.Length / partitions;   // 2
                        int startIndex = 0;                             // 0
                        int endIndex = length;                          // 2
                        for (int i = 0; i < partitions - 1; i++)
                        {                                                                // 01   23   45   678
                            currentList.Add(currentWord.Substring(startIndex, length));  // Sv   et   os   lav
                            startIndex += endIndex;
                        }
                        currentList.Reverse();
                        list.RemoveAt(index);
                        for (int i = 0; i < currentList.Count; i++)
                        {
                            list.Insert(index, currentList[i]);
                        }
                        int startOfTheRest = (partitions - 1) * length;
                        list.Insert(index + partitions - 1, currentWord.Substring(startOfTheRest, currentWord.Length - startOfTheRest));

                    }

                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
