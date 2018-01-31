using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < n + 'a'; i++)
            {
                for (char j = 'a'; j < n + 'a'; j++)
                {
                    for (char k = 'a'; k < n + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
