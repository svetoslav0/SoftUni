using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var homeTownDays = double.Parse(Console.ReadLine());
            double totalGames = (48 - homeTownDays) * 0.75 + homeTownDays + holidays * 2 / 3;
            if (yearType == "leap")
            {
                totalGames = totalGames + totalGames * 0.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
