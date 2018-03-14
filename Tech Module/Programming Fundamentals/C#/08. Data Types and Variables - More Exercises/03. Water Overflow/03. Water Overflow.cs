using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int pour = 0;
            int totalLiters = 0;
            for (int i = 0; i < n; i++)
            {
                pour = int.Parse(Console.ReadLine());
                if (pour + totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    totalLiters += pour;
                }

            }
            Console.WriteLine(totalLiters);
        }
    }
}
