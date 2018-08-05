using System;
using System.Text.RegularExpressions;

namespace _03._Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();
            string line5 = Console.ReadLine();
            bool isValid = true;
            Regex surfacePattern = new Regex(@"[^\w]+");
            Regex mantlePattern = new Regex(@"[\d_]+");
            Regex middlePattern = new Regex(@"[^\w]+[\d_]+[a-zA-Z]+[\d_]+[^\w]+");
            Regex corePattern = new Regex(@"[a-zA-Z]+");
            if (surfacePattern.Match(line1).ToString() != line1)  isValid = false;
            if (mantlePattern.Match(line2).ToString() != line2) isValid = false;
            if (middlePattern.Match(line3).ToString() != line3) isValid = false;
            if (mantlePattern.Match(line4).ToString() != line4) isValid = false;
            if (surfacePattern.Match(line5).ToString() != line5) isValid = false;

            if (!isValid)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
                string core = corePattern.Match(line3).ToString();
                Console.WriteLine(core.Length);
            }
        }
    }
}
