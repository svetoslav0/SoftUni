using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string current;
            string result = "BALANCED";
            string wholeString = "";
            int sumOpening = 0;
            int sumClosing = 0;
            for (int i = 1; i <= n; i++)
            {
                current = Console.ReadLine();
                wholeString += current;
            }
            string noWhiteSpaces = Regex.Replace(wholeString, @"\s+", "");
            string nothingButBrackets = "";
            for (int i = 0; i < noWhiteSpaces.Length; i++)
            {
                if (noWhiteSpaces[i] == '(' || noWhiteSpaces[i] == ')')
                {
                    nothingButBrackets += noWhiteSpaces[i];
                }
            }
            // case 1 START
            if (nothingButBrackets[0] == ')' || nothingButBrackets[nothingButBrackets.Length-1] == '(')
            {
                result = "UNBALANCED";
            }
            // case 1 END
            // case 2 START
            for (int i = 0; i < nothingButBrackets.Length; i++)
            {
                if (nothingButBrackets[i] == '(')
                {
                    sumOpening++;
                }
                if (nothingButBrackets[i] == ')')
                {
                    sumClosing++;
                }
            }
            if (sumOpening != sumClosing)
            {
                result = "UNBALANCED";
            }
            // case 2 END
            // case 3 START
            for (int i = 0; i < noWhiteSpaces.Length-1; i++)
            {
                if (noWhiteSpaces[i] == '(' && noWhiteSpaces[i + 1] == '(')
                {
                    result = "UNBALANCED";
                    break;
                }
                if (noWhiteSpaces[i] == ')' && noWhiteSpaces[i + 1] == ')')
                {
                    result = "UNBALANCED";
                    break;
                }
            }
            // case 3 END
            // case 4 START
            for (int i = 0; i < nothingButBrackets.Length-1; i++)
            {
                if (nothingButBrackets[i] == nothingButBrackets[i+1])
                {
                    result = "UNBALANCED";
                    break;
                }
            }
            // case 4 END
            Console.WriteLine(result);
        }
    }
}
