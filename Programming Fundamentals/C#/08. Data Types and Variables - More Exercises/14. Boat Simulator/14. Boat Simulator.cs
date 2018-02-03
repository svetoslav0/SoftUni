using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boatOne = char.Parse(Console.ReadLine());
            char boatTwo = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string speedString = "";
            int speed = 0;
            int boatOneMoves = 0;
            int boatTwoMoves = 0;
            for (int i = 1; i <= n; i++)
            {
                speedString = Console.ReadLine();
                speed = speedString.Length;
                if (boatOneMoves >= 50 || boatTwoMoves >= 50)
                {
                    break;
                }
                if (speedString == "UPGRADE")
                {
                    boatOne += (char)3;
                    boatTwo += (char)3;
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        boatOneMoves += speed;
                    }
                    else
                    {
                        boatTwoMoves += speed;
                    }
                }
            }
            if (boatOneMoves > boatTwoMoves)
            {
                Console.WriteLine(boatOne);
            }
            else
            {
                Console.WriteLine(boatTwo);
            }
        }
    }
}
