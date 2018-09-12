using System;

namespace _03._Game_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine($"Match has just began!");
            }
            else if (minutes < 45)
            {
                Console.WriteLine($"First half time.");
                if (minutes <= 10)
                {
                    Console.WriteLine($"{name} missed a penalty.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{name} was injured after the penalty.");
                    }
                }
                else if (minutes <= 35)
                {
                    Console.WriteLine($"{name} received yellow card.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{name} got another yellow card.");
                    }
                }
                else
                {
                    Console.WriteLine($"{name} SCORED A GOAL !!!");
                }
            }
            else
            {
                Console.WriteLine($"Second half time.");
                if (minutes <= 55 && minutes > 45)
                {
                    Console.WriteLine($"{name} got a freekick.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{name} missed the freekick.");
                    }
                }
                else if (minutes <= 80 && minutes > 55)
                {
                    Console.WriteLine($"{name} missed a shot from corner.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{name} has been changed with another player.");
                    }
                }
                else if (minutes > 80)
                {
                    Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
                }
            }
        }
    }
}
