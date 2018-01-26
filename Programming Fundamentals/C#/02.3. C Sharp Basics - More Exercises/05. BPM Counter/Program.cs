using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var beats = double.Parse(Console.ReadLine());
            double bars = Math.Round(beats / 4, 1);
            double seconds = Math.Floor(60 / (bpm / beats));
            int minutes = (int)seconds / 60;
            Console.WriteLine($"{bars} bars - {minutes}m {seconds%60}s");

        }
    }
}
