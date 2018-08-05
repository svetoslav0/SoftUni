using System;

namespace _01._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTrashed = 0;
            double mouseTrashed = 0;
            double keyboardTrashed = 0;
            double displayTrashed = 0;

            double helper = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashed++;
                }

                if (i % 3 == 0)
                {
                    mouseTrashed++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardTrashed++;
                }

                if (keyboardTrashed % 2 == 0 && keyboardTrashed != 0 && helper != keyboardTrashed)
                {
                    displayTrashed++;
                    helper = keyboardTrashed;
                }
            }

            double totalCost = headsetPrice * headsetTrashed +
                               mouseTrashed * mousePrice + 
                               keyboardTrashed * keyboardPrice + 
                               displayTrashed * displayPrice;


            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");

        }
    }
}
