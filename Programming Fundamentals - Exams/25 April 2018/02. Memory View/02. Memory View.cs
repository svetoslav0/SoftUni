using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string collectedData = "";

            while (input != "Visual Studio crash")
            {
                collectedData += $"{input} ";
                input = Console.ReadLine();
            }
            collectedData = collectedData.Trim();

            string[] messages = collectedData.Split("32656 19759 32763 0 ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            // "5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0 0 "
            // "7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0"

            for (int i = 0; i < messages.Length; i++)
            {
                string helper = messages[i];
                List<int> current = helper.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int[] messageInAscii = new int[current[0]];

                current.RemoveAt(0);

                for (int j = 0; j < current.Count; j++)
                {
                    if (current[j] == 0)
                    {
                        current.RemoveAt(j);
                        j--;
                    }
                }

                string finalMessage = "";

                for (int j = 0; j < current.Count; j++)
                {
                    char sym = (char)current[j];
                    finalMessage += sym;
                }
                if (finalMessage != "")
                {
                    Console.WriteLine(finalMessage);
                }



            }


        }
    }
}
