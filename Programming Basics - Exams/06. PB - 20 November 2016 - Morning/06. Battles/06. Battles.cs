using System;

namespace _06._Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int maximumFights = int.Parse(Console.ReadLine());

            int fights = 0;
            bool finished = false;
            for (int i = 1; i <= first; i++)
            {
                for (int j = 1; j <= second; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    fights++;
                    if (fights >= maximumFights)
                    {
                        finished = true;
                        break;
                    }
                }
                if (finished)
                {
                    break;
                }
            }
        }
    }
}
