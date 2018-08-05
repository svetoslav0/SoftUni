using System;

namespace _04._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from thte console
            double money = double.Parse(Console.ReadLine());
            double destinationYear = double.Parse(Console.ReadLine());
            double age = 18;

            // Calculate the total money the boy needs
            for (int i = 1800; i <= destinationYear; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + age * 50;
                }
                age++;
            }

            // Check if the money would be enough and print the result
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {-money:f2} dollars to survive.");
            }
        }
    }
}
