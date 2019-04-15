using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine());

            double totalElectricity = 0;
            double totalWater = 20 * months;
            double totalInternet = 15 * months;
            double totalOthers = 0;

            for (int i = 0; i < months; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());
                totalElectricity += electricityPrice;
                totalOthers += (electricityPrice + 35) * 1.2;
            }


            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOthers:f2} lv");
            Console.WriteLine($"Average: " +
                $"{(totalElectricity + totalWater + totalInternet + totalOthers) / months:f2} lv");

        }
    }
}
