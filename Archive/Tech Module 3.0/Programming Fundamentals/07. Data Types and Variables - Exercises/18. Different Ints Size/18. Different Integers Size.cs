using System;

namespace _18._Different_Ints_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = "";
            try
            {
                string input = Console.ReadLine();
                current = input;
                long number = long.Parse(input);
                Console.WriteLine($"{number} can fit in:");
                if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (number <= byte.MaxValue && number >= byte.MinValue)
                {
                    Console.WriteLine("* byte");
                }
                if (number <= short.MaxValue && number >= short.MinValue)
                {
                    Console.WriteLine("* short");
                }
                if (number <= ushort.MaxValue && number >= ushort.MinValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (number <= int.MaxValue && number >= int.MinValue)
                {
                    Console.WriteLine("* int");
                }
                if (number <= uint.MaxValue && number >= uint.MinValue)
                {
                    Console.WriteLine("* uint");
                }
                if (number <= long.MaxValue && number >= long.MinValue)
                {
                    Console.WriteLine("* long");
                }

            }
            catch (Exception)
            {
                Console.WriteLine($"{current} can't fit in any type");
            }
        }
    }
}
