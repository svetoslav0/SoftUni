using System;

namespace _03._On_Time_for_the_Exam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());                                   // (+) if late
            var examMin = int.Parse(Console.ReadLine());                                    // (-) if early
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMin = int.Parse(Console.ReadLine());
            TimeSpan examTime = TimeSpan.Parse($"{examHour}:{examMin}");
            TimeSpan arrivalTime = TimeSpan.Parse($"{arrivalHour}:{arrivalMin}");
            TimeSpan t1 = arrivalTime.Subtract(examTime);
            int diffHours = Int32.Parse(t1.ToString().Split(':')[0]);
            int diffMins = Int32.Parse(t1.ToString().Split(':')[1]);
            if (diffHours == 0)
            {
                if (arrivalTime > examTime)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffMins:d2} minutes after the start");
                }
                else
                {
                    if (diffMins > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{diffMins} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("On time");
                        if (diffMins > 0)
                        {
                            Console.WriteLine($"{diffMins} minutes before the start");
                        }
                    }
                }
            }
            else if (diffHours > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffHours}:{diffMins:d2} hours after the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{-diffHours}:{diffMins:d2} hours before the start");
            }
        }
    }
}