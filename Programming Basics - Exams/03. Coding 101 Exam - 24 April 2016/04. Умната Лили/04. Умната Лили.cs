using System;

namespace _04._Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washingPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double birthdaysMoney = 10;
            double totalMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)  // When Lily gets money
                {
                    totalMoney += birthdaysMoney;
                    birthdaysMoney += 10;
                }
                else // When she gets toy
                {
                    totalMoney += toyPrice;
                }
            }
            double takenMoney = Math.Floor(age / 2);
            totalMoney -= takenMoney;
            if (totalMoney >= washingPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washingPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingPrice - totalMoney:f2}");
            }

        }
    }
}
