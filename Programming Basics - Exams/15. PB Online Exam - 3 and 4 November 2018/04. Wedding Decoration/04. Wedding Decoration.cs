using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double moneySpend = 0;

            double balloons = 0;
            double flowers = 0;
            double candles = 0;
            double ribbon = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    Console.WriteLine($"Spend money: {moneySpend:f2}");
                    Console.WriteLine($"Money left: {budget - moneySpend:f2}");
                    break;
                }

                if (moneySpend >= budget)
                {
                    Console.WriteLine("All money is spent!");
                    break;
                }

                string product = command;
                double count = double.Parse(Console.ReadLine());

                switch (product)
                {
                    case "balloons":
                        moneySpend += count * 0.1;
                        balloons += count;
                        break;
                    case "flowers":
                        moneySpend += count * 1.5;
                        flowers += count;
                        break;
                    case "candles":
                        moneySpend += count * 0.5;
                        candles += count;
                        break;
                    case "ribbon":
                        moneySpend += count * 2;
                        ribbon += count;
                        break;
                }
            }

            Console.WriteLine($"Purchased decoration is {balloons} balloons, " +
                $"{ribbon} m ribbon, {flowers} flowers and {candles} candles.");

        }
    }
}
