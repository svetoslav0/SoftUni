using System;

namespace _01._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double totalSabers = Math.Ceiling(students * 1.1);
            double totalSabrePrice = sabrePrice * totalSabers;
            double totalRobePrice = robePrice * students;
            double freeBelts = Math.Floor(students / 6);
            double totalBeltPrice = beltPrice * (students - freeBelts);
            double totalCost = totalSabrePrice + totalRobePrice + totalBeltPrice;

            if (totalCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalCost - money:f2}lv more.");
            }
        }
    }
}
