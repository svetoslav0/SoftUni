using System;

namespace _11._5_Different_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b - a < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i1 = a; i1 < b; i1++)
                {
                    for (int i2 = a + 1; i2 < b; i2++)
                    {
                        for (int i3 = a + 2; i3 <= b; i3++)
                        {
                            for (int i4 = a + 3; i4 <= b; i4++)
                            {
                                for (int i5 = a + 4; i5 <= b; i5++)
                                {
                                    if (a <= i1 && i1 < i2 && i2 < i3 && i3 < i4 && i4 < i5 && i5 <= b)
                                    {
                                        Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}