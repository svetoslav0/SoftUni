using System;
using System.Text.RegularExpressions;

namespace _03._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();
            string placeholderMessage = Console.ReadLine();
            var placeholders = Regex.Matches(placeholderMessage,@"[^{}]+");
            Regex placeholderRegex = new Regex(@"([a-z]+)([a-z]+)(\1)");








            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine();
            }
            string text = "SevenOneTextTwoEighth";
            Regex reg1 = new Regex(@"One([A-Za-z]+)Two");
            var found = reg1.Match(text);
            Console.WriteLine(found);
            var only = found.Groups[1].Value;
            Console.WriteLine(only);
        }
    }
}
