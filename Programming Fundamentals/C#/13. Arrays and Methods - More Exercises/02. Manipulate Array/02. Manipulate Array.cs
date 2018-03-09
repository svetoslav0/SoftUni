using System;
using System.Collections.Generic;

namespace _02._Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Reverse":
                        words = ArrayReverse(words);
                        break;
                    case "Distinct":
                        words = Distinct(words);
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string stringWord = command[2];
                        words = Replace(words, index, stringWord);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }


        private static string[] ArrayReverse(string[] words)
        {
            string[] reversedArr = new string[words.Length];
            for (int i = 0, j = words.Length - 1; i < words.Length; i++, j--)
            {
                reversedArr[i] = words[j];
            }
            return reversedArr;
        }

        private static string[] Distinct(string[] words) // one one one two three four five
        {
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i]))
                {
                    dict[words[i]] = 1;
                }
                else
                {
                    dict[words[i]]++;
                }
            }
            string[] newWords = new string[dict.Count];
            int j = 0;
            foreach (var word in dict)
            {
                newWords[j] = word.Key;
                j++;
            }
            return newWords;
        
        }
        private static string[] Replace(string[] words, int index, string stringWord)
        {
            string[] newWords = words;
            newWords[index] = stringWord;
            return newWords;
        }
    }
}
