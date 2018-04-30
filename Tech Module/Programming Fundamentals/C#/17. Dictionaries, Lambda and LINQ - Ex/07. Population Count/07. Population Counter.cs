using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            var data = new Dictionary<string, Dictionary<string, long>>();
            string country;
            string city;
            long population;
            while (input[0] != "report")
            {
                country = input[1];
                city = input[0];
                population = long.Parse(input[2]);

                if (!data.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    data.Add(country, currentCity);
                }
                else
                {
                    if (!data[country].ContainsKey(city))
                    {
                        data[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var currentCountry in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{currentCountry.Key} (total population: {currentCountry.Value.Values.Sum()})");
                foreach (var currentCity in currentCountry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{currentCity.Key}: {currentCity.Value}");
                }
            }

        }
    }
}
