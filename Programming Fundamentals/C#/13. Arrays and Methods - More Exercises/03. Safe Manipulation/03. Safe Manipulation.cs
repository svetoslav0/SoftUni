using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Reverse":
                        words = words.Reverse().ToArray();
                        break;
                    case "Distinct":
                        words = words.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string stringWord = command[2];
                        if (index >= 0 && index <= words.Length - 1)
                        {
                            words = Replace(words, index, stringWord);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }
        private static string[] Replace(string[] words, int index, string stringWord)
        {
            string[] newWords = words;
            newWords[index] = stringWord;
            return newWords;
        }
    }

}
