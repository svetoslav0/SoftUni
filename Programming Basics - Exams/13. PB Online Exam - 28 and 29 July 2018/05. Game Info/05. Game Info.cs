using System;

namespace _05._Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int totalMinutes = 0;
            int gamesAddTime = 0;
            int gamesPenalties = 0;

            for (int i = 0; i < games; i++)
            {
                int currentGame = int.Parse(Console.ReadLine());
                totalMinutes += currentGame;

                if (currentGame > 90 && currentGame <= 120)
                {
                    gamesAddTime++;
                }
                else if (currentGame > 120)
                {
                    gamesPenalties++;
                }
            }

            Console.Write($"{team} has played {totalMinutes} minutes. ");
            Console.WriteLine($"Average minutes per game: {(double)totalMinutes / games:f2}");
            Console.WriteLine($"Games with penalties: {gamesPenalties}");
            Console.WriteLine($"Games with additional time: {gamesAddTime}");
        }
    }
}
