using System;

namespace _07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine($"{new string(' ',n-i)}{new string('*',i)} | {new string('*', i)}");
            }

        }
    }
}
