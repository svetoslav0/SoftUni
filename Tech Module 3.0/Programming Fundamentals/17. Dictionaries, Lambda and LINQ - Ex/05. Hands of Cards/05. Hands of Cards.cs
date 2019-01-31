using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "JOKER")
                {
                    break;
                }

                var name = input[0];
                var currentCards = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (!cards.ContainsKey(name))
                {
                    cards[name] = new List<string>();
                }
                foreach (var item in currentCards)
                {
                    cards[name].Add(item);
                }
                cards[name] = cards[name].Distinct().ToList();
            }
            Dictionary<string, int> points = new Dictionary<string, int>();

            foreach (var item in cards)
            {
                int currentPoints = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    string powerAsStr = new string(item.Value[i].Reverse().Skip(1).Reverse().ToArray());
                    string typeAsStr = new string(item.Value[i].Reverse().Take(1).ToArray());
                    int power = 0;
                    int type = 0;
                    switch (powerAsStr)
                    {
                        case "J":
                            power = 11;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "A":
                            power = 14;
                            break;
                        default:
                            power = int.Parse(powerAsStr);
                            break;
                    }

                    switch (typeAsStr)
                    {
                        case "S":
                            type = 4;
                            break;
                        case "H":
                            type = 3;
                            break;
                        case "D":
                            type = 2;
                            break;
                        case "C":
                            type = 1;
                            break;
                    }
                    currentPoints += type * power;
                    points[item.Key] = currentPoints;
                }
            }

            foreach (var kvp in points)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
        }
    }
}
