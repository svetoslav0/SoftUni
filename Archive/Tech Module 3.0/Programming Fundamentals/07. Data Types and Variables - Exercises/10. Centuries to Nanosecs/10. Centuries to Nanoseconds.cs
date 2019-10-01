using System;

namespace _10._Centuries_to_Nanosecs
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong miliseconds = (ulong)(seconds * 1000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {miliseconds}000 microseconds = {miliseconds}000000 nanoseconds");
        }
    }
}
