using System;
using System.Linq;
namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();
            string[] lineOne = stringOne.Split(' ');
            string[] lineTwo = stringTwo.Split(' ');
            int maxLen = (lineOne.Length > lineTwo.Length) ? lineOne.Length : lineTwo.Length;
            int minLen = (maxLen == lineTwo.Length) ? lineOne.Length : lineTwo.Length;
            int sumIncrease = 0;
            int sumDecrease = 0;
            for (int i = 0; i < minLen; i++)
            {
                if (lineOne[i] == lineTwo[i])
                {
                    sumIncrease++;
                }
                else
                {
                    break;
                }
            }
            lineOne = lineOne.Reverse().ToArray();
            lineTwo = lineTwo.Reverse().ToArray();
            for (int i = 0; i < minLen; i++)
            {
                if (lineOne[i] == lineTwo[i])
                {
                    sumDecrease++;
                }
                else
                {
                    break;
                }

            }
            int result = (sumIncrease > sumDecrease) ? sumIncrease : sumDecrease;
            Console.WriteLine(result);

        }
    }
}
