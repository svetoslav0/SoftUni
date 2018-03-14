using System;

namespace _17._Print_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            for (char i = (char)start; i <= (char)end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
