using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var char1 = char.Parse(Console.ReadLine());
            var char2 = char.Parse(Console.ReadLine());
            var magic = char.Parse(Console.ReadLine());

            for (char i = char1; i <= char2; i++)
            {
                for (char j = char1; j <= char2; j++)
                {
                    for (char k = char1; k <= char2; k++)
                    {
                        if (magic != i && magic != j && magic != k)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
