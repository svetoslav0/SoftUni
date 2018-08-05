using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'S' || input[j] == 's' || input[j] == 'T' || input[j] == 't' || input[j] == 'A' || input[j] == 'a' || input[j] == 'R' || input[j] == 'r')
                    {
                        counter++;
                    }
                }
                string decryptedMessage = "";
                for (int j = 0; j < input.Length; j++)
                {
                    decryptedMessage += (char)(input[j] - counter);
                }
                Regex planetNameRegex = new Regex(@"@[A-Z|a-z]+");
                Regex populationRegex = new Regex(@":[0-9]+");
                Regex attackTypeRegex = new Regex(@"![A,D]!");
                Regex soldierRegex = new Regex(@"->[0-9]+");
                Match attackTypeMatch = attackTypeRegex.Match(decryptedMessage);
                string attackTypeAsStr = attackTypeMatch.ToString();
                int population, soldiers;
                bool isPopulationValid = int.TryParse(populationRegex.Match(decryptedMessage).ToString().Remove(0, 1), out population);
                
                bool isSoldierValid = int.TryParse(soldierRegex.Match(decryptedMessage).ToString().Remove(0, 2), out soldiers);
                
                string planetName = planetNameRegex.Match(decryptedMessage).ToString().TrimStart('@');
                char attackType = attackTypeAsStr[1];
                if (attackType == 'A' && isSoldierValid && isPopulationValid)
                {
                    attackedPlanets.Add(planetName);
                }
                else if (attackType == 'D' && isSoldierValid && isPopulationValid)
                {
                    destroyedPlanets.Add(planetName);
                }


            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            for (int i = 0; i < attackedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {attackedPlanets[i]}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            for (int i = 0; i < destroyedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {destroyedPlanets[i]}");
            }


        }
    }
}
