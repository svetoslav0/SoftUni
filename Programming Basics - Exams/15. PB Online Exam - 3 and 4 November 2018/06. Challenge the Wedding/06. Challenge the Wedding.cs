using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menCounter = int.Parse(Console.ReadLine());
            int womenCounter = int.Parse(Console.ReadLine());
            int tablesCount = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFull = false;

            for (int i = 1; i <= menCounter; i++)
            {
                for (int j = 1; j <= womenCounter; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter >= tablesCount)
                    {
                        isFull = true;
                        break;
                    }
                }

                if (isFull)
                {
                    break;
                }
            }
        }
    }
}
