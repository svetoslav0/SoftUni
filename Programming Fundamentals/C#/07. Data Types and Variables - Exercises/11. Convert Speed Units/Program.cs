using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            float timeInHours = hours + minutes / 60 + seconds / 3600;
            float kmPerHour = meters / 1000 / timeInHours;
            float metersPerHour = kmPerHour / 3.6f;
            float milesPerHour = kmPerHour / 1.609f;
            Console.WriteLine(metersPerHour);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
