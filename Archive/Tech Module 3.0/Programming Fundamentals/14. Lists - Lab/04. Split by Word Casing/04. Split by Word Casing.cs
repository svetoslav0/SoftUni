using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new[] { ' ', ',' , ';' , ':' , '.' , '!' , '(' , ')' , '"', '\'' , '\\' , '/' , '[' , ']'}).ToList();
            List<string> lowers = new List<string>();
            List<string> mixed = new List<string>();
            List<string> uppers = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                bool uppChar = false;
                bool lowChar = false;
                bool others = false;
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (currentWord[j] >= 'a' && currentWord[j] <= 'z')
                    {
                        lowChar = true;
                    }
                    else if (currentWord[j] >= 'A' && currentWord[j] <= 'Z')
                    {
                        uppChar = true;
                    }
                    else
                    {
                        others = true;
                    }
                }
                if ((uppChar && lowChar) || others)
                {
                    mixed.Add(currentWord);
                }
                else if (uppChar && !lowChar)
                {
                    uppers.Add(currentWord);
                }
                else if (!uppChar && lowChar)
                {
                    lowers.Add(currentWord);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowers)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppers)}");
        }
    }
}
