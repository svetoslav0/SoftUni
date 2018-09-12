using System;

namespace _04._Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int points = 0;
            int goalDiff = 0;

            for (int i = 0; i < games; i++)
            {
                int goalsWeScored = int.Parse(Console.ReadLine());
                int goalsOthersScored = int.Parse(Console.ReadLine());

                if (goalsWeScored > goalsOthersScored)
                {
                    points += 3;
                }
                else if (goalsOthersScored == goalsWeScored)
                {
                    points++;
                }
                goalDiff += goalsWeScored - goalsOthersScored;
            }

            if (goalDiff >= 0)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {goalDiff}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalDiff}.");
            }
        }
    }
}
