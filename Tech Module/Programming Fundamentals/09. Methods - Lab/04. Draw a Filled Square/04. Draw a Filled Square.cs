using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderAndFooter(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddlePart(n);
            }
            PrintHeaderAndFooter(n);
        }
        static void PrintHeaderAndFooter(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMiddlePart(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
