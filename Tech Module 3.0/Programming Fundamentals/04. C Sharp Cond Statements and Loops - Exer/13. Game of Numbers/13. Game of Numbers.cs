using System;

namespace _13._Game_of_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());
            string result = "";
            int sum = 0;
            int p = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    sum++;
                    if (i + j == magic)
                    {
                        result = $"Number found! {i} + {j} = {magic}";
                        p++;
                    }
                }
            }
            if (p!=0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{sum} combinations - ");
                Console.WriteLine($"neither equals {magic}");
            }
        }
    }
}