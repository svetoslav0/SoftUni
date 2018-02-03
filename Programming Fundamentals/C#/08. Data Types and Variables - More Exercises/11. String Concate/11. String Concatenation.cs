using System;

namespace _11._String_Concate
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = "";
            string result = "";
            char dilimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                current = Console.ReadLine();
                if (evenOrOdd == "even" && i % 2 == 0)
                {
                    result += current + dilimiter;
                }
                else if(evenOrOdd == "odd" && i % 2 == 1)
                {
                    result += current + dilimiter;
                }
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }
    }
}
