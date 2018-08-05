using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                string quantity = Console.ReadLine();
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = int.Parse(quantity);
                }
                else
                {
                    resources[resource] += int.Parse(quantity);
                }
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
