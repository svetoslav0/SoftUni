using System;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',n-i-1));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = n; i > 0; i--)
            {
                Console.Write(new string(' ',n-i+1));
                for (int j = i; j > 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
