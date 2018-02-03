using System;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long intNumber = long.Parse(Console.ReadLine());
            long sbyteNumber = long.Parse(Console.ReadLine());
            long temp;
            if (sbyteNumber > intNumber)
            {
                temp = intNumber;
                intNumber = sbyteNumber;
                sbyteNumber = temp;
            }
            long sum = 10 * intNumber + 4 * sbyteNumber;
            Console.WriteLine(sum);

        }
    }
}
