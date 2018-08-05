using System;

namespace _04._SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line reads from the console how much groups will go to the camp
            double groups = double.Parse(Console.ReadLine());

            double car = 0,
                microbus = 0,
                smallBus = 0,
                bigBus = 0,
                train = 0,
                totalPeople = 0;
            

            for (int i = 0; i < groups; i++)
            {
                // Read the count of every group and add it to the corresponding traveling group 
                double currentGroup = double.Parse(Console.ReadLine());
                if (currentGroup <= 5)
                {
                    car += currentGroup;
                }
                else if (currentGroup <= 12)
                {
                    microbus += currentGroup;
                }
                else if (currentGroup <= 25)
                {
                    smallBus += currentGroup;
                }
                else if (currentGroup <= 40)
                {
                    bigBus += currentGroup;
                }
                else
                {
                    train += currentGroup;
                }
                totalPeople += currentGroup;
            }

            // Print the results data in percentage
            Console.WriteLine($"{car / totalPeople * 100:f2}%");
            Console.WriteLine($"{microbus / totalPeople * 100:f2}%");
            Console.WriteLine($"{smallBus / totalPeople * 100:f2}%");
            Console.WriteLine($"{bigBus / totalPeople * 100:f2}%");
            Console.WriteLine($"{train / totalPeople * 100:f2}%");
        }
    }
}
