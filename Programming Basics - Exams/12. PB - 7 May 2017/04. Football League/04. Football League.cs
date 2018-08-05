using System;

namespace _04._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the capacity and the count of the people
            double capacity = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            double countSectorA = 0;
            double countSectorB = 0;
            double countSectorV = 0;
            double countSectorG = 0;

            for (int i = 0; i < people; i++)
            {
                // Distribure every person in the following sector
                string currentPerson = Console.ReadLine();

                switch (currentPerson)
                {
                    case "A":
                        countSectorA++;
                        break;
                    case "B":
                        countSectorB++;
                        break;
                    case "V":
                        countSectorV++;
                        break;
                    case "G":
                        countSectorG++;
                        break;
                }
            }

            // Prdouble every sector's percentage and the stadium's percentage
            Console.WriteLine($"{countSectorA / people * 100:f2}%");
            Console.WriteLine($"{countSectorB / people * 100:f2}%");
            Console.WriteLine($"{countSectorV / people * 100:f2}%");
            Console.WriteLine($"{countSectorG / people * 100:f2}%");
            Console.WriteLine($"{people / capacity * 100:f2}%");

        }
    }
}
