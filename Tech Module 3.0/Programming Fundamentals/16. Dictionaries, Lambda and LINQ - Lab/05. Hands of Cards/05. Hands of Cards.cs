using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointsDict = new Dictionary<string, int>();
            while (true)
            {
                string inputText = Console.ReadLine();  // Pesho Peshov: 5A, 10H
                if (inputText == "JOKER")
                {
                    break;
                }
                List<string> splitByDots = inputText.Split(':').ToList();   // [0]: Pesho Peshov [1]: 5A, 10H
                string name = splitByDots[0];
                List<string> arrInput = splitByDots[1]
                    .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList(); // [0]: 5A [1]: 10H
                for (int i = 0; i < arrInput.Count; i++)
                {
                    for (int j = i + 1; j < arrInput.Count; j++)
                    {
                        if (arrInput[i] == arrInput[j])
                        {
                            arrInput.RemoveAt(j);
                            j--;
                        }
                    }
                }
                int pointsForRun = 0;
                for (int i = 0; i < arrInput.Count; i++)
                {
                    string type = new string(arrInput[i].Reverse().Skip(1).Reverse().ToArray());
                    string power = new string(arrInput[i].Reverse().Take(1).ToArray());
                    int currentPoints = 0;
                    int typePoints = 0;
                    int powerPoints = 0;
                    switch (power)
                    {
                        case "S":
                            typePoints = 4;
                            break;
                        case "H":
                            typePoints = 3;
                            break;
                        case "D":
                            typePoints = 2;
                            break;
                        case "C":
                            typePoints = 1;
                            break;
                    }
                    switch (type)
                    {
                        case "J":
                            powerPoints = 11;
                            break;
                        case "Q":
                            powerPoints = 12;
                            break;
                        case "K":
                            powerPoints = 13;
                            break;
                        case "A":
                            powerPoints = 14;
                            break;
                        default:
                            powerPoints = int.Parse(type);
                            break;
                    }
                    currentPoints = powerPoints * typePoints;
                    pointsForRun += currentPoints;
                }
                if (!pointsDict.ContainsKey(arrInput[0]))
                {
                    pointsDict[name] = pointsForRun;
                }
                else
                {
                    pointsDict[name] += pointsForRun;
                }

            }
            foreach (var kvp in pointsDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
