using System;

namespace _02._Vapor_Store
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            double startMoney = money;
            string game = "";
            while (true)
            {
                game = Console.ReadLine();
                switch (game)
                {
                    case "OutFall 4":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (money >= 15.99)
                        {
                            money -= 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (money >= 19.99)
                        {
                            money -= 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (money >= 59.99)
                        {
                            money -= 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (money >= 29.99)
                        {
                            money -= 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= 39.99)
                        {
                            money -= 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                        

                    default:
                        if (game != "Game Time")
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                }
                if (game == "Game Time")
                {
                    if (money > 0)
                    {
                        Console.WriteLine($"Total spent: ${startMoney - money:f2}. Remaining: ${money:f2}");
                        break;
                    }
                    else if(money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
        }
    }
}