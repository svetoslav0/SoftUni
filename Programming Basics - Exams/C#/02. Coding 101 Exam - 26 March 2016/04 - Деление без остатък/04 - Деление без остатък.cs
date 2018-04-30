using System;

namespace _4___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double counterByTwo = 0, counterByThree = 0, counterByFour = 0;
            for (double i = 0; i < n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    counterByTwo++;
                }
                if (currentNum % 3 == 0)
                {
                    counterByThree++;
                }
                if (currentNum % 4 == 0)
                {
                    counterByFour++;
                }
            }
            Console.WriteLine($"{counterByTwo * 100 / n:f2}%");
            Console.WriteLine($"{counterByThree * 100 / n:f2}%");
            Console.WriteLine($"{counterByFour * 100 / n:f2}%");
        }
    }
}
