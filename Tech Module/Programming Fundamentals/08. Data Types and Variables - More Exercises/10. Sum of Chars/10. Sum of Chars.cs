using System;

namespace _10._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                symbol = char.Parse(Console.ReadLine());
                sum += symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
