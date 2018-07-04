using System;

namespace _04._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the number of the packages
            int n = int.Parse(Console.ReadLine());
            double totalWeight = 0, smallPacks = 0, middlePacks = 0, bigPacks = 0;

            // Distribute each pack in a different group (variable)
            for (int i = 0; i < n; i++)
            {
                int currentWeight = int.Parse(Console.ReadLine());
                totalWeight += currentWeight;

                if (currentWeight <= 3)
                {
                    smallPacks += currentWeight;
                }
                else if (currentWeight <= 11)
                {
                    middlePacks += currentWeight;
                }
                else
                {
                    bigPacks += currentWeight;
                }
            }

            // Calculate the average weight
            double average = (smallPacks * 200 + middlePacks * 175 + bigPacks * 120) / totalWeight;
            Console.WriteLine($"{average:f2}");

            // Calculate every type by percentages and print them
            double smallPercentage = (smallPacks / totalWeight) * 100;
            double middlePercentage = middlePacks / totalWeight * 100;
            double bigPercentage = bigPacks / totalWeight * 100;

            Console.WriteLine($"{smallPercentage:f2}%");
            Console.WriteLine($"{middlePercentage:f2}%");
            Console.WriteLine($"{bigPercentage:f2}%");
        }
    }
}
