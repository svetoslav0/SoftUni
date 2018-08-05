using System;

namespace _02._Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            double weekendDays = double.Parse(Console.ReadLine());

            double weekendDaysMins = weekendDays * 127;
            double workingDaysMins = (365 - weekendDays) * 63;
            double totalMins = weekendDaysMins + workingDaysMins;
            double diff = Math.Abs(30000 - totalMins);
            double hours = Math.Floor(diff / 60);
            double minutes = diff % 60;

            if (totalMins < 30000 )
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
