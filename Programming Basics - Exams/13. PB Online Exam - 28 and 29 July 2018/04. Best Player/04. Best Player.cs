using System;

namespace _04._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            string bestPlayer = "";
            int bestGoals = 0;
            bool madeHatTrick = false;
            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > bestGoals)
                {
                    bestGoals = goals;
                    bestPlayer = player;
                }
                if (bestGoals >= 3)
                {
                    madeHatTrick = true;
                }
                if (bestGoals >= 10)
                {
                    break;
                }
                player = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (madeHatTrick)
            {
                Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoals} goals.");
            }
        }
    }
}
